using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetsGame.Abstracts
{
    public abstract class IController
    {
        public Utils.DataSupplier DataSupplier;
        public System.Windows.Controls.Frame FrameMVC;
        public IModel Model;
    }
}
