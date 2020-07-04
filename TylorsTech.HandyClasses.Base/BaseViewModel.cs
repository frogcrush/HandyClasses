using System.Threading.Tasks;

namespace TylorsTech.HandyClasses.Base
{
    public abstract class BaseViewModel : BaseModel
    {
        private bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set { SetProperty(ref isBusy, value); }
        }

        private bool firstLoad = true;

        public BaseViewModel()
        {
            if (firstLoad)
            {
                firstLoad = false;
                Task.Run(async () => await OnFirstLoad()).ContinueWith(x =>
                {
                    if (x.IsFaulted)
                        throw x.Exception;
                }).ConfigureAwait(false);
            }
        }

        public virtual async Task OnFirstLoad()
        {

        }
    }
}
