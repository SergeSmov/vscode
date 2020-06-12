using System;

namespace xb9d8bb5e6df032aa
{
    class x1110bdd110cdcea4
    {

        static void Main(string[] args)
        {
            string message = string.Intern(x1110bdd110cdcea4._xaacba899487bce8c(
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
                            "lgnglnnaleofllopfcpojjpojaackhackoahkfblfmb", 7400187));
            Console.WriteLine(message);
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
            arrch = new char[x5e99b576d2530d13.Length / 4];

            i = 0;

            while (true)
            {
                i++;
                if (i < (x5e99b576d2530d13.Length / 4))
                {
                    usht1 = (ushort)(x5e99b576d2530d13[4 * i] - 'a' +
                                      ((x5e99b576d2530d13[(4 * i) + 1] - 'a') << '\u0004') +
                                      ((x5e99b576d2530d13[(4 * i) + 2] - 'a') << '\u0008') +
                                      ((x5e99b576d2530d13[(4 * i) + 3] - 'a') << '\u000c'));
                    usht1 -= usht;
                    arrch[i] = (char)(short)usht1;
                    usht += 1789;
                }
                else
                {
                    str = new string(arrch);
                    return str;
                }

            }
        }
    }
}
