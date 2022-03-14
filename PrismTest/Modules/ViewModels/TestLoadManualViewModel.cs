using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modules.ViewModels
{
    /// <summary>
    /// TestLoadManual 是该模型的窗体容器，名称要根据规范来命名 TestLoadManual + ViewModel  不然无法加载模型数据( 也可以自定义模型来实现，在10-CustomRegistrations示例中可以)
    /// </summary>
    public class TestLoadManualViewModel : BindableBase
    {
        private string _title = "Prism Unity Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private List<string> _comList = new List<string>();
        public List<string> ComList
        {
            get { return _comList; }
            set { SetProperty(ref _comList, value); }
        }


        public TestLoadManualViewModel()
        {
            _comList.Add("COM5");

            
        }
  
    }
}
