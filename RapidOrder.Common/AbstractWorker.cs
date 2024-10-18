using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapidOrder.Common
{
    public abstract class AbstractWorker : BackgroundService
    {
        public event DoWorkEventHandler? DoWork;
        protected AbstractWorker() { }
     
    }
}
