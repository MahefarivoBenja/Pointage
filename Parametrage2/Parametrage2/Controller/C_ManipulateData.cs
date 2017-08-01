using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Parametrage2.Controller
{
    class C_ManipulateData
    {
        public string[] ListeMatricule(string matricule)
        {
            string[] parMatricule = System.Text.RegularExpressions.Regex.Split(matricule, ",");
            string[] listeMatricule = new string[parMatricule.Length];
            for (int i = 0; i < parMatricule.Length; i++)
            {
                try
                {
                    string tempMatricule = parMatricule[i].ToString();
                    string[] reelMatricule = System.Text.RegularExpressions.Regex.Split(tempMatricule, "-");
                    string matr = reelMatricule[0].ToString();
                    listeMatricule[i] = matr;
                }
                catch (System.Exception exc)
                {
                    System.Windows.Forms.MessageBox.Show(exc.Message);
                }
            }
            return listeMatricule;
        }
        public void ResetFiltre(CheckedComboBox cclb)
        {
            try
            {
                for (int i = 0; i < cclb.Items.Count; i++)
                {
                    cclb.SetItemChecked(i, false);
                }
                cclb.Text = "--Choisir--";
            }
            catch(System.Exception exc)
            {
                System.Windows.Forms.MessageBox.Show("ResetFiltre :"+exc.Message);
            }
           
        }
        public string GetLocalIpAddress()
        {
            UnicastIPAddressInformation mostSuitableIp = null;

            var networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

            foreach (var network in networkInterfaces)
            {
                if (network.OperationalStatus != OperationalStatus.Up)
                    continue;

                var properties = network.GetIPProperties();

                if (properties.GatewayAddresses.Count == 0)
                    continue;

                foreach (var address in properties.UnicastAddresses)
                {
                    if (address.Address.AddressFamily != AddressFamily.InterNetwork)
                        continue;

                    if (IPAddress.IsLoopback(address.Address))
                        continue;

                    if (!address.IsDnsEligible)
                    {
                        if (mostSuitableIp == null)
                            mostSuitableIp = address;
                        continue;
                    }

                    // The best IP is the IP got from DHCP server
                    if (address.PrefixOrigin != PrefixOrigin.Dhcp)
                    {
                        if (mostSuitableIp == null || !mostSuitableIp.IsDnsEligible)
                            mostSuitableIp = address;
                        continue;
                    }

                    return address.Address.ToString();
                }
            }

            return mostSuitableIp != null ? mostSuitableIp.Address.ToString() : "";
        }

    }
}
