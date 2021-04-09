using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace PlanetsGame.Controllers
{
    public class MakingOfController : BaseController
    {
        Models.MakingOfModel model;

        public MakingOfController()
        {
        }

        public Abstracts.IModel Model
        {
            get
            {
                model = new Models.MakingOfModel()
                {
                    Lang = Utils.DataSupplier.Self.Lang,
                    MakingOfText = Utils.DataSupplier.Self.GetText("MAKINGOF_InfoText"),
                    LangImage = new BitmapImage(new Uri(string.Format("pack://application:,,,/PlanetsGame;component/Resources/{0}.png", Utils.DataSupplier.Self.LangNext.ToLower())))
                };
                return model;
            }
        }
    }
}
