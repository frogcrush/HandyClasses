// Copyright (c) Sven Groot (Ookii.org) 2006
// See license.txt for details
using System;

namespace TylorsTech.HandyClasses.WPF.Dialogs
{
    class VistaFileDialogEvents : TylorsTech.HandyClasses.WPF.Dialogs.Interop.IFileDialogEvents, TylorsTech.HandyClasses.WPF.Dialogs.Interop.IFileDialogControlEvents
    {
        const uint S_OK = 0;
        const uint S_FALSE = 1;
        const uint E_NOTIMPL = 0x80004001;

        private FileDialog _dialog;

        public VistaFileDialogEvents(FileDialog dialog)
        {
            if (dialog == null)
                throw new ArgumentNullException("dialog");

            _dialog = dialog;
        }

        #region IFileDialogEvents Members

        public TylorsTech.HandyClasses.WPF.Dialogs.Interop.HRESULT OnFileOk(TylorsTech.HandyClasses.WPF.Dialogs.Interop.IFileDialog pfd)
        {
            if (_dialog.DoFileOk(pfd))
                return TylorsTech.HandyClasses.WPF.Dialogs.Interop.HRESULT.S_OK;
            else
                return TylorsTech.HandyClasses.WPF.Dialogs.Interop.HRESULT.S_FALSE;
        }

        public TylorsTech.HandyClasses.WPF.Dialogs.Interop.HRESULT OnFolderChanging(TylorsTech.HandyClasses.WPF.Dialogs.Interop.IFileDialog pfd, TylorsTech.HandyClasses.WPF.Dialogs.Interop.IShellItem psiFolder)
        {
            return TylorsTech.HandyClasses.WPF.Dialogs.Interop.HRESULT.S_OK;
        }

        public void OnFolderChange(TylorsTech.HandyClasses.WPF.Dialogs.Interop.IFileDialog pfd)
        {
        }

        public void OnSelectionChange(TylorsTech.HandyClasses.WPF.Dialogs.Interop.IFileDialog pfd)
        {
        }

        public void OnShareViolation(TylorsTech.HandyClasses.WPF.Dialogs.Interop.IFileDialog pfd, TylorsTech.HandyClasses.WPF.Dialogs.Interop.IShellItem psi, out NativeMethods.FDE_SHAREVIOLATION_RESPONSE pResponse)
        {
            pResponse = NativeMethods.FDE_SHAREVIOLATION_RESPONSE.FDESVR_DEFAULT;
        }

        public void OnTypeChange(TylorsTech.HandyClasses.WPF.Dialogs.Interop.IFileDialog pfd)
        {
        }

        public void OnOverwrite(TylorsTech.HandyClasses.WPF.Dialogs.Interop.IFileDialog pfd, TylorsTech.HandyClasses.WPF.Dialogs.Interop.IShellItem psi, out NativeMethods.FDE_OVERWRITE_RESPONSE pResponse)
        {
            pResponse = NativeMethods.FDE_OVERWRITE_RESPONSE.FDEOR_DEFAULT;
        }

        #endregion

        #region IFileDialogControlEvents Members

        public void OnItemSelected(TylorsTech.HandyClasses.WPF.Dialogs.Interop.IFileDialogCustomize pfdc, int dwIDCtl, int dwIDItem)
        {
        }

        public void OnButtonClicked(TylorsTech.HandyClasses.WPF.Dialogs.Interop.IFileDialogCustomize pfdc, int dwIDCtl)
        {
        }

        public void OnCheckButtonToggled(TylorsTech.HandyClasses.WPF.Dialogs.Interop.IFileDialogCustomize pfdc, int dwIDCtl, bool bChecked)
        {
        }

        public void OnControlActivating(TylorsTech.HandyClasses.WPF.Dialogs.Interop.IFileDialogCustomize pfdc, int dwIDCtl)
        {
        }

        #endregion


    }
}
