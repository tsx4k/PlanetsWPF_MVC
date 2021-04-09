using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PlanetsGame.Controllers
{
    public class BaseController : Abstracts.IController
    {
        public new Utils.DataSupplier DataSupplier { get { return Utils.DataSupplier.Self; } }
        public new Frame FrameMVC { get { return DataSupplier.Frame; } }
    }
}
