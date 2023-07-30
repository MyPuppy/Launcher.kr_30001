using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KartRider;
using KartRider.IO;
using RiderData;

namespace ExcData
{
    public static class KartExcData
    {
        public static void Kart_ExcData()
        {
            int TuneCount = NewRider.Kart_Old_Cut;
            int PlantCount = NewRider.Kart_Old_Cut;
            short KartSN = Launcher.KartOld_SN;

            if (Program.UseKartTune)
            {
                using (OutPacket oPacket = new OutPacket("LoRpGetRiderExcDataPacket"))
                {
                    oPacket.WriteByte(1);
                    oPacket.WriteByte(0);
                    oPacket.WriteInt(TuneCount);
                    for (short i = 1; i <= NewRider.MaxKart; i++)
                    {
                        if (i <= 25 || i == 27 || i == 29 || i == 45 || i == 54 || i == 59 ||
                            i == 63 || i == 70 || i == 82 || i == 95 || i == 101 || i == 103 || i == 111 || i == 114 || i == 117 || i == 210 || i == 219 || i == 220 || i == 232 || i == 265 || i == 285 ||
                            i == 292 || i == 302 || i == 311 || i == 326 || i == 357 || i == 358 || i == 361 || i == 371 || i == 378 || i == 382 || i == 420 || i == 429 || i == 433 || i == 436 || i == 437 ||
                            i == 439 || i == 453 || i == 458 || i == 459 || i == 464 || i == 473 || i == 481 || i == 484 || i == 501 || i == 510 || i == 517 || i == 531 || i == 543 || i == 550 || i == 559 ||
                            i == 564 || i == 566 || i == 574 || i == 596 || i == 597 || i == 602 || i == 604 || i == 606 || i == 608 || i == 611 || i == 619 || i == 620 || i == 624 || i == 627 || i == 630 ||
                            i == 633 || i == 636 || i == 639 || i == 643 || i == 644 || i == 647 || i == 650 || i == 666 || i == 671 || i == 681 || i == 684 || i == 700 || i == 701 || i == 702 || i == 703 ||
                            i == 704 || i == 706 || i == 707 || i == 719 || i == 720 || i == 737 || i == 738 || i == 739 || i == 788 || i == 750 || i == 751 || i == 757 || i == 764 || i == 787 || i == 794 ||
                            i == 795 || i == 796 || i == 797 || i == 800 || i == 801 || i == 805 || i == 806 || i == 808 || i == 811 || i == 813 || i == 824 || i == 827 || i == 828 || i == 829 || i == 830 ||
                            i == 832 || i == 833 || i == 835 || i == 837 || i == 838 || i == 839 || i == 840 || i == 841 || i == 843 || i == 844 || i == 845 || i == 847 || i == 850 || i == 851 || i == 852 ||
                            i == 1193 || i == 1195 || i == 1199 || i == 1206 || i == 1208 || i == 1212 || i == 1215 || i == 1221 || i == 1222 || i == 1225 || i == 1226 || i == 1229 || i == 1230 || i == 1234 || i == 1238 ||
                            i == 1239 || i == 1247 || i == 1251 || i == 1252 || i == 1261 || i == 1265 || i == 1268 || i == 1271 || i == 1275 || i == 1285 || i == 1297 || i == 1302)
                        {
                            oPacket.WriteShort(3);
                            oPacket.WriteShort(i);
                            oPacket.WriteShort(KartSN);
                            oPacket.WriteShort(0);
                            oPacket.WriteShort(0);
                            if (i == 700 || i == 701 || i == 702 || i == 703 || i == 704 || i == 750 || i == 751 || i == 788)//Type C
                            {
                                oPacket.WriteShort(903);
                                oPacket.WriteShort(702);
                                oPacket.WriteShort(602);
                            }
                            else if (i == 633 || i == 647 || i == 650 || i == 671 || i == 681 || i == 719 || i == 787) //Type H
                            {
                                oPacket.WriteShort(603);
                                oPacket.WriteShort(903);
                                oPacket.WriteShort(702);
                            }
                            else //Type A
                            {
                                oPacket.WriteShort(603);
                                oPacket.WriteShort(703);
                                oPacket.WriteShort(903);
                            }
                            oPacket.WriteShort(0);
                            oPacket.WriteShort(0);
                            oPacket.WriteShort(0);
                            oPacket.WriteShort(0);
                        }
                    }
                    oPacket.WriteInt(0);
                    RouterListener.MySession.Client.Send(oPacket);
                }
            }
            else
            {
                using (OutPacket oPacket = new OutPacket("LoRpGetRiderExcDataPacket"))
                {
                    oPacket.WriteByte(1);
                    oPacket.WriteByte(0);
                    oPacket.WriteInt(15);
                    for (short i = 1; i <= NewRider.MaxKart; i++)
                    {
                        if (i == 700 || i == 701 || i == 702 || i == 703 || i == 704 || i == 750 || i == 751 || i == 788 || i == 633 || i == 647 || 
                            i == 650 || i == 671 || i == 681 || i == 719 || i == 787)
                        {
                            oPacket.WriteShort(3);
                            oPacket.WriteShort(i);
                            oPacket.WriteShort(KartSN);
                            oPacket.WriteShort(0);
                            oPacket.WriteShort(0);
                            if (i == 700 || i == 701 || i == 702 || i == 703 || i == 704 || i == 750 || i == 751 || i == 788)//Type C
                            {
                                oPacket.WriteShort(903);
                                oPacket.WriteShort(702);
                                oPacket.WriteShort(602);
                            }
                            else if (i == 633 || i == 647 || i == 650 || i == 671 || i == 681 || i == 719 || i == 787) //Type H
                            {
                                oPacket.WriteShort(603);
                                oPacket.WriteShort(903);
                                oPacket.WriteShort(702);
                            }
                            else //Type A
                            {
                                oPacket.WriteShort(603);
                                oPacket.WriteShort(703);
                                oPacket.WriteShort(903);
                            }
                            oPacket.WriteShort(0);
                            oPacket.WriteShort(0);
                            oPacket.WriteShort(0);
                            oPacket.WriteShort(0);
                        }
                    }
                    oPacket.WriteInt(0);
                    RouterListener.MySession.Client.Send(oPacket);
                }
            }
            if (Program.UseKartPlant)
            {
                using (OutPacket oPacket = new OutPacket("LoRpGetRiderExcDataPacket"))
                {
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(1);
                    oPacket.WriteInt(0);
                    oPacket.WriteInt(PlantCount);
                    for (short i = 1; i <= NewRider.MaxKart; i++)
                    {
                        if (i <= 25 || i == 27 || i == 29 || i == 45 || i == 54 || i == 59 ||
                            i == 63 || i == 70 || i == 82 || i == 95 || i == 101 || i == 103 || i == 111 || i == 114 || i == 117 || i == 210 || i == 219 || i == 220 || i == 232 || i == 265 || i == 285 ||
                            i == 292 || i == 302 || i == 311 || i == 326 || i == 357 || i == 358 || i == 361 || i == 371 || i == 378 || i == 382 || i == 420 || i == 429 || i == 433 || i == 436 || i == 437 ||
                            i == 439 || i == 453 || i == 458 || i == 459 || i == 464 || i == 473 || i == 481 || i == 484 || i == 501 || i == 510 || i == 517 || i == 531 || i == 543 || i == 550 || i == 559 ||
                            i == 564 || i == 566 || i == 574 || i == 596 || i == 597 || i == 602 || i == 604 || i == 606 || i == 608 || i == 611 || i == 619 || i == 620 || i == 624 || i == 627 || i == 630 ||
                            i == 633 || i == 636 || i == 639 || i == 643 || i == 644 || i == 647 || i == 650 || i == 666 || i == 671 || i == 681 || i == 684 || i == 700 || i == 701 || i == 702 || i == 703 ||
                            i == 704 || i == 706 || i == 707 || i == 719 || i == 720 || i == 737 || i == 738 || i == 739 || i == 788 || i == 750 || i == 751 || i == 757 || i == 764 || i == 787 || i == 794 ||
                            i == 795 || i == 796 || i == 797 || i == 800 || i == 801 || i == 805 || i == 806 || i == 808 || i == 811 || i == 813 || i == 824 || i == 827 || i == 828 || i == 829 || i == 830 ||
                            i == 832 || i == 833 || i == 835 || i == 837 || i == 838 || i == 839 || i == 840 || i == 841 || i == 843 || i == 844 || i == 845 || i == 847 || i == 850 || i == 851 || i == 852 ||
                            i == 1193 || i == 1195 || i == 1199 || i == 1206 || i == 1208 || i == 1212 || i == 1215 || i == 1221 || i == 1222 || i == 1225 || i == 1226 || i == 1229 || i == 1230 || i == 1234 || i == 1238 ||
                            i == 1239 || i == 1247 || i == 1251 || i == 1252 || i == 1261 || i == 1265 || i == 1268 || i == 1271 || i == 1275 || i == 1285 || i == 1297 || i == 1302)
                        {
                            oPacket.WriteShort(i);
                            oPacket.WriteShort(KartSN);
                            oPacket.WriteInt(4);
                            oPacket.WriteShort(43);
                            oPacket.WriteShort(23);
                            oPacket.WriteShort(44);
                            oPacket.WriteShort(2);
                            oPacket.WriteShort(45);
                            oPacket.WriteShort(23);
                            oPacket.WriteShort(46);
                            oPacket.WriteShort(1);
                        }
                    }
                    RouterListener.MySession.Client.Send(oPacket);
                }
            }
        }
    }
}