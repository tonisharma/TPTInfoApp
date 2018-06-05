using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Windows.Input;

using Xamarin.Forms;

namespace TPTInfoApp.ViewModels
{
    class KasulikudLingid : BaseViewModel
    {
        public KasulikudLingid()
        {
            Title = "Useful links";

            Kirjalike_toode_vormistamise_juhend = new Command(() => Device.OpenUri(new Uri("https://tptliveee-my.sharepoint.com/personal/info_tptlive_ee/_layouts/15/guestaccess.aspx?guestaccesstoken=CoiNNZnYM976%2bQw3YxQizeFGV34AoAJgArV31Bm6gn0%3d&docid=0011a5b5d7e8b43aca34c89cc26757915")));
            Praktikajuhend = new Command(() => Device.OpenUri(new Uri("https://tptliveee-my.sharepoint.com/:b:/g/personal/info_tptlive_ee/EfbWi7f-u5ZFh8EPmdXUE54ByLT0-TX7mpm5S3bEDgl44g?e=QxakC6")));
            Sisekorraeeskiri = new Command(() => Device.OpenUri(new Uri("https://tptliveee-my.sharepoint.com/personal/info_tptlive_ee/_layouts/15/guestaccess.aspx?guestaccesstoken=0GQHb1buAehZFWPOP2qc4hZVDgeKBgB%2fhIrdg8w6RP0%3d&docid=0c329114c31c84b739172cfb0cb8eea52")));
            Opilasesindus = new Command(() => Device.OpenUri(new Uri("https://www.tptlive.ee/opilasele/opilasesindus/")));
            Oppetoetus = new Command(() => Device.OpenUri(new Uri("https://www.tptlive.ee/oppetoo/oppekorralduseeskiri/")));
        }

        public ICommand Kirjalike_toode_vormistamise_juhend { get; }
        public ICommand Praktikajuhend { get; }
        public ICommand Sisekorraeeskiri { get; }
        public ICommand Opilasesindus { get; }
        public ICommand Oppetoetus { get; }
    }
}
