using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DataFormXamarin
{
    public class DataFormViewModel
    {
        private DataFormModel loginInfo;
        public DataFormModel LoginInfo
        {
            get { return loginInfo; }
            set { loginInfo = value; }
        }

        public DataFormViewModel()
        {
            loginInfo = new DataFormModel();
            this.ValidateCommand = new Command<object>(this.OnValidate);
        }
        public Command<object> ValidateCommand { get; set; }
        private void OnValidate(object dataForm)
        {
            var dataFormLayout = dataForm as Syncfusion.XForms.DataForm.SfDataForm;
            dataFormLayout.Validate();
        }
    }
}
