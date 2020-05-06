using System.Windows.Input;
using ContactSharingXF.Helpers;
using ContactSharingXF.Models;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ContactSharingXF.ViewModels
{
    public class ContactPageViewModel
    {
        public string FormattedName{ get => "Charlin Agramonte"; }
        public string FirstName { get => "Charlin"; }
        public string LastName { get => "Agramonte"; }
        public string Organization { get => "Crossgeeks"; }
        public string OrganizationTitle { get => "Mobile Developer"; }
        public string Phone1 { get => "14045554554"; }
        public string Phone1Type { get => "HOME"; }
        public string Phone2 { get => "15045551212"; }
        public string Phone2Type { get => "WORK"; }
        public string Email { get => "charlin@crossgeeks.com"; }
        public string Address { get => "100 Waters Edge Baytown, LA 30314 United States of America"; }
        public string AddressType { get => "work"; }
        public string Photo { get => "https://pbs.twimg.com/profile_images/872843398889132038/QVlsE3W5_400x400.jpg"; }

        public ICommand ShareCommand => new Command(async () =>
        {
            VcfContact vcfContact = new VcfContact()
            {
                FirstName = FirstName,
                LastName = LastName,
                FormattedName= FormattedName,
                Email =Email,
                Organization=Organization,
                Photo= Photo,
                Title = OrganizationTitle,
                Phones = new System.Collections.Generic.List<VcfPhone>()
                {
                   { new VcfPhone(){ Number=Phone1, Type=Phone1Type} },
                   { new VcfPhone(){ Number=Phone2, Type=Phone2Type} }
                },
                Addresses = new System.Collections.Generic.List<VcfAddress>()
                {
                   { new VcfAddress(){ Description=Address, Type=AddressType} }
                }
            };

            await Share.RequestAsync(new ShareFileRequest
            {
                Title = FormattedName,
                File = new ShareFile(VcfFileHelper.CreateFile(vcfContact))
            });
        });
    }
}
