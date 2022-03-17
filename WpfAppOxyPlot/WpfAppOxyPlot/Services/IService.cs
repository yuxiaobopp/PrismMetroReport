using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppOxyPlot.Services
{
    public interface IService
    {
        /// <summary>
        /// Start service.
        /// </summary>
        void OnStart();

        /// <summary>
        /// Stop service, cleanup data.
        /// </summary>
        void OnStop();

        /// <summary>
        /// 初始化下拉框
        /// </summary>
        void InitUserControlsComboBox();
    }
}
