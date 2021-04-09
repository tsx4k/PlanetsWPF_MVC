using PlanetsGame.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace PlanetsGame.Controllers
{
    public class IntroController : BaseController
    {
        Models.IntroModel model;

        public IntroController()
        {
        }

        public Abstracts.IModel Model
        {
            get
            {
                model = new Models.IntroModel()
                {
//                    Lang = Utils.DataSupplier.Self.Lang,
//                    TouchText = Utils.DataSupplier.Self.GetText("INTRO_TouchText"),
//                    InfoText = Utils.DataSupplier.Self.GetText("INTRO_InfoText"),
//                    LangImage = new BitmapImage(new Uri(string.Format("pack://application:,,,/PlanetsGame;component/Resources/{0}.png", Utils.DataSupplier.Self.LangNext.ToLower())))
                };
                return model;
            }
        }
    }
}
