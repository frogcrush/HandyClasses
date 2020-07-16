using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TylorsTech.HandyClasses.Base
{
    public class ActionCommand<T> : ICommand
    {
        Action<T> _action;

        private bool _canExecute = true;

        /// <summary>
        /// Manually sets if this command is allowed to execute. 
        /// </summary>
        public bool GlobalCanExecute
        {
            get => _canExecute;
            set
            {
                _canExecute = value;
                CanExecuteChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Function called to determine if we CanExecute on a parameter.
        /// </summary>
        public Func<object, bool> CanExecuteCheck { get; set; } 

        public ActionCommand(Action<T> a)
        {
            _action = a;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            if (CanExecuteCheck != null)
                return CanExecuteCheck.Invoke(parameter);
            return GlobalCanExecute;
        }

        public void Execute(object parameter)
        {
            _action?.Invoke((T)parameter);
        }
    }

    public class ActionCommand : ICommand
    {
        private Action _action;

        private bool _canExecute = true;

        /// <summary>
        /// Manually sets if this command is allowed to execute. 
        /// </summary>
        public bool GlobalCanExecute
        {
            get => _canExecute;
            set
            {
                _canExecute = value;
                CanExecuteChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public ActionCommand(Action action)
        {
            _action = action;
        }

        public bool CanExecute(object parameter)
        {
            return GlobalCanExecute;
        }

        public void Execute(object parameter)
        {
            _action.Invoke();
        }

        public event EventHandler CanExecuteChanged;
    }
}
