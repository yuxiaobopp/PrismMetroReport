using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModuleA.ViewModels
{
    public class ModuleAViewModel: BindableBase
    {
        private string _title = "A";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public ModuleAViewModel()
        {

        }
    }
}
