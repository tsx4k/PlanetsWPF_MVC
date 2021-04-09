using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace PlanetsGame.Controllers
{
    public class StartController : BaseController
    {
        Models.StartModel model;

        public StartController()
        {
        }

        public Abstracts.IModel Model
        {
            get
            {
                model = new Models.StartModel()
                {
                    Lang = Utils.DataSupplier.Self.Lang,
                    StartText = Utils.DataSupplier.Self.GetText("START_AboutText"),
//                    LangImage = new BitmapImage(new Uri(string.Format("pack://application:,,,/PlanetsGame;component/Resources/{0}.png", Utils.DataSupplier.Self.LangNext.ToLower())))
                };
                return model;
            }
        }
    }
}
