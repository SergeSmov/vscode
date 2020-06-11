using System.Windows.Forms;


namespace xb9d8bb5e6df032aa
{
    class x1110bdd110cdcea4
    {
        static void Main(string[] args)
        {
            MessageBox.Show(string.Intern(x1110bdd110cdcea4._xaacba899487bce8c(
                            "eflohgcpkgjpegaapahapboajbfbdbmbhedcbekcgfbdkphdlepdgegekdnepcefhdlfiobggcjgadahd" +
                            "chhmnnhncfiobmiibdjanjjcoakkmhklapkfaglkbnloldmcalmkacngpinfppnepgomknojpeplolpf" +
                            "pcajojamoabonhbhjobmnfccnmcboddlikdnmbedniegmpeemgfamnfhiegghlghkchiljhglainlhih" +
                            "goififjdkmjnkdkalkkmkblffilehplojgmeknmjeennjlnmicomijojiapkdhpihopaifaiimapgdbe" +
                            "ikblhbcfcicegpceggdmbndmgeeoflecgcfhgjflfagkahgicogcdfhfcmhopcipekiaebjkdijeepje" +
                            "dgkmomkaeelpcllpccmmcjmnnpmmbhnmboneneocbmoomcppakpnababbiadapaibgbmlmbiaecmpkcd" +
                            "lbddmidnkpdnpgemonehoefaplfmocgpnjgloahfjhhdnohdofimimimndjknkjembkcnikbnpkpmglh" +
                            "mnlciemlflmifcnekjnhlaoklhocgoomkfpblmpmkdakkkadfbbakibckpbmjgckincmiedcildbjcea" +
                            "ijeidafbihflhofchfgbhmghhdhjhkhigbidhiinbpioggjggnjebekfflkhfclofjljeamhehmoeome" +
                            "efnmplnnedoodkoidbpaphpbeppmdgaadnafcebnclbonbcacjcgcadmbhdlbodnbfebbmejmcfhakfb" +
                            "bbgeaignlognpfhganhcaeifalihpbjjpijnppjkogkcknkepelpollcocmeojmknanajhnbooncnfom" +
                            "mmoeidpemkpnmbajmiammpahmgbbmnbllecpllcjgcdpkjdblaeaghegloejkffmkmfgkdgbfkgcjbha" +
                            "jihojphkigioinioiejmiljgicklhjkbialeihlncolkhfmjhmmdhdnlgkndgboofiomgpoiggpacnpp" +
                            "aeabelamfcblejbdaacefhcfeocpdfdhpldaedekdkemdbfgdifldpffofgecngecehiclhiccincjid" +
                            "npiechjmbojkmekoamkjadlfbklolamhaimbapmipfnhpmnnpdoppkooobpgkipdpppcpgagonanneba" +
                            "olbcoccinjcoiadmmhdgnodjmfecimeomdfomkfnlbglligfmpgjlghllnhbleihglinkcjpkjjekakk" +
                            "khkkkokckfldjmldkdmfjkmijbnejinbfpnaegoggnoaiephdlpnicaaijadiablchbphobggfcahmcd" +
                            "hddmbkdkfbeegiedbpeffgffgnfofegmelgcfchefjhheaikehigeoifpejidmjoddkodkkjoallcilj" +
                            "dplbcgmjcnmpceniblniccokbjonbapjbhpennpfmeacbmaladbbakbkpacjaicipocalfdapmdjpdef" +
                            "pkeipbfcoifbopfpoggijngkoehfolhpicibojimnajpmhjbnojhmfknhmkomdlplkljlbmbhimklpme" +
                            "lgnglnnaleofllopfcpojjpojaackhackoahkfblfmb", 7400187)));

        }

        public x1110bdd110cdcea4() : base()
        {
        }

        public static string _xaacba899487bce8c(string x5e99b576d2530d13, int x2710752c36f2d14b)
        {
            ushort usht;
            char[] arrch;
            int i;
            ushort usht1;
            string str;
            usht = (ushort)x2710752c36f2d14b;
            goto ILO_007f;
            while (true)
            {
                i++;
            ILO_000c:
                if (i < (x5e99b576d2530d13.Length / 4))
                {
                    break;
                }
                str = new string(arrch);
                if (!0.Equals(0))
                {
                    goto ILO_008d;
                }
                return str;

                ILO_0027(ref i, ref usht, ref usht1, ref arrch, x5e99b576d2530d13);

            ILO_007f:
                arrch = new char[x5e99b576d2530d13.Length / 4];

                ILO_008d(ref i, ref usht, ref usht1);

                goto ILO_000c;
                return str;
            }
        }


        private static void ILO_008d(ref int i, ref ushort usht, ref ushort usht1)
        {
            i = 0;
            if ((((((uint)usht)) + (((uint)usht1))) > -1))
            {
                ILO_008d(ref i, ref usht, ref usht1);
            }
        }

        private static void ILO_0027(ref int i, ref ushort usht, ref ushort usht1, ref char[] arrch, string x5e99b576d2530d13)
        {

            arrch[i] = (char)(ushort)usht1;
            usht += 1789;

            usht1 = (ushort)((((x5e99b576d2530d13[4 * i] - 'a') + ((x5e99b576d2530d13[(4 * i) + 1] - 'a') << '\u0004')) + 
                ((x5e99b576d2530d13[(4 * i) + 2] - 'a') << '\u0008')) + ((x5e99b576d2530d13[(4 * i) + 3] - 'a') << '\u000c'));
            usht1 -= usht;
            ILO_0027(ref i, ref usht, ref usht1, ref arrch, x5e99b576d2530d13);
        }
    }

}
