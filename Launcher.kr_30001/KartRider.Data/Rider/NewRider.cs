﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KartRider.IO;
using KartRider;
using ExcData;
using Set_Data;

namespace RiderData
{
    public static class NewRider
    {
        public static short Value1 = 30000;
        public static short Value2 = 1;

        public static short Kart_Old_Cut = 0;

        public static short MaxKart = 0;

        public static void LoadItemData()
        {
            NewRider.Kart();
            NewRider.Pet();
            NewRider.FlyingPet();
            NewRider.Character();
            NewRider.BonusCard();
            NewRider.HandGearL();
            NewRider.HeadBand();
            NewRider.Goggle();
            NewRider.Balloon();
            NewRider.SlotItem();
            NewRider.MyRoom();
            NewRider.RenameRid();
            NewRider.ReplayTicket();
            NewRider.LucciBag();
            NewRider.Uniform();
            NewRider.Plate();
            NewRider.RidColor();
            NewRider.SkidMark();
            NewRider.Aura();
            NewRider.Paint();
            KartExcData.Kart_ExcData();
            NewRider.NewRiderData();//라이더 인식
            Launcher.OpenGetItem = true;
        }

        public static void NewRiderData()
        {
            using (OutPacket oPacket = new OutPacket("PrGetRider"))
            {
                oPacket.WriteByte(1);
                oPacket.WriteString(SetRider.Nickname);
                oPacket.WriteShort(0);
                oPacket.WriteShort(0);
                oPacket.WriteShort(SetRider.Emblem1);
                oPacket.WriteShort(SetRider.Emblem2);
                oPacket.WriteShort(0);
                oPacket.WriteShort(SetRiderItem.Set_Character);
                oPacket.WriteShort(SetRiderItem.Set_Paint);
                if (Launcher.KartOld_SN == SetRiderItem.Set_KartSN)
                {
                    oPacket.WriteShort(SetRiderItem.Set_Kart);
                }
                else
                {
                    oPacket.WriteShort(0);
                }
                oPacket.WriteShort(SetRiderItem.Set_Plate);
                oPacket.WriteShort(SetRiderItem.Set_Goggle);
                oPacket.WriteShort(SetRiderItem.Set_Balloon);
                oPacket.WriteShort(0);
                oPacket.WriteShort(SetRiderItem.Set_HeadBand);
                oPacket.WriteShort(0);
                oPacket.WriteShort(SetRiderItem.Set_HandGearL);
                oPacket.WriteShort(0);
                oPacket.WriteShort(SetRiderItem.Set_Uniform);
                oPacket.WriteShort(0);
                oPacket.WriteShort(SetRiderItem.Set_Pet);
                oPacket.WriteShort(SetRiderItem.Set_FlyingPet);
                oPacket.WriteShort(SetRiderItem.Set_Aura);
                oPacket.WriteShort(SetRiderItem.Set_SkidMark);
                oPacket.WriteShort(0);
                oPacket.WriteShort(SetRiderItem.Set_RidColor);
                oPacket.WriteShort(SetRiderItem.Set_BonusCard);
                oPacket.WriteShort(0);
                if (SetRiderItem.Set_KartSN == Launcher.KartOld_SN)
                {
                    if (Program.UseKartPlant)
                    {
                        oPacket.WriteShort(23);
                        oPacket.WriteShort(23);
                        oPacket.WriteShort(2);
                        oPacket.WriteShort(1);
                    }
                    else
                    {
                        oPacket.WriteShort(0);
                        oPacket.WriteShort(0);
                        oPacket.WriteShort(0);
                        oPacket.WriteShort(0);
                    }
                }
                else
                {
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(0);
                }
                oPacket.WriteShort(Launcher.KartOld_SN);
                oPacket.WriteString("");
                oPacket.WriteUInt(SetRider.Lucci);
                oPacket.WriteInt(SetRider.RP);
                for (int i = 0; i < 25; i++)
                {
                    oPacket.WriteInt(0);
                }
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void KartSN()
        {
            NewRider.Kart_Old_Cut = 177;
            NewRider.MaxKart = 1302;

            Launcher.KartOld_SN = 1;
            Launcher.KartSN = 1000;
        }

        public static void Kart()
        {
            int All_Kart =  NewRider.Kart_Old_Cut;
            using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
            {
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                oPacket.WriteInt(All_Kart);
                //-----------------------------------------------------------------------------------------------------------------
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
                        oPacket.WriteShort(Launcher.KartOld_SN);
                        oPacket.WriteShort(NewRider.Value2);
                        oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                        oPacket.WriteByte(0);
                        oPacket.WriteShort(-1);
                        oPacket.WriteShort(0);
                    }
                }
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void Paint()
        {
            using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
            {
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                int Paint = 46;
                oPacket.WriteInt(Paint - 7);
                for (short i = 1; i <= Paint; i++)
                {
                    if (i == 13 || i == 31 || i == 33 || i == 34 || i == 35 || i == 37 || i == 39)
                    {
                    }
                    else 
                    {
                        oPacket.WriteShort(2);
                        oPacket.WriteShort(i);
                        oPacket.WriteShort(0);
                        oPacket.WriteShort(NewRider.Value2);
                        oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                        oPacket.WriteByte(0);
                        oPacket.WriteShort(-1);
                        oPacket.WriteShort(0);
                    }
                }
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void Character()
        {
            using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
            {
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                int Character = 131;
                oPacket.WriteInt(Character - 9 - 21);
                for (short i = 1; i <= Character; i++)//Character
                {
                    if (i == 47 || i == 48 || i == 63 || i == 116 || i == 117 || i == 122 || i == 124 || i == 128 || i == 130 || 

                        i == 33 || i == 34 || i == 35 || i == 36 || i == 45 || i == 52 || i == 56 || i == 57 || i == 58 || i == 59 ||
                        i == 67 || i == 70 || i == 79 || i == 80 || i == 81 || i == 83 || i == 85 || i == 110 || i == 112 || i == 121 || 
                        i == 126)
                    {
                    }
                    else
                    {
                        oPacket.WriteShort(1);
                        oPacket.WriteShort(i);
                        oPacket.WriteShort(0);
                        oPacket.WriteShort(NewRider.Value2);
                        oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                        oPacket.WriteByte(0);
                        oPacket.WriteShort(-1);
                        oPacket.WriteShort(0);
                    }
                }
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void Pet()
        {
            using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
            {
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                int Pet = 106;
                oPacket.WriteInt(Pet + 6 - 13);
                for (short i = 30003; i <= 30008; i++)
                {
                    oPacket.WriteShort(21);
                    oPacket.WriteShort(i);
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(NewRider.Value2);
                    oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(-1);
                    oPacket.WriteShort(0);
                }
                for (short i = 1; i <= Pet; i++)
                {
                    if (i == 8 || i == 10 || i == 11 || i == 14 || i == 18 || i == 50 || i == 77 || i == 85 || i == 91 || i == 92 || 
                        i == 100 || i == 101 || i == 105)
                    {
                    }
                    else
                    {
                        oPacket.WriteShort(21);
                        oPacket.WriteShort(i);
                        oPacket.WriteShort(0);
                        oPacket.WriteShort(NewRider.Value2);
                        oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                        oPacket.WriteByte(0);
                        oPacket.WriteShort(-1);
                        oPacket.WriteShort(0);
                    }
                }
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void FlyingPet()
        {
            using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
            {
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                int FlyingPet = 30;
                oPacket.WriteInt(FlyingPet - 5);
                for (short i = 1; i <= FlyingPet; i++)
                {
                    if (i == 20 || i == 21 || i == 22 || i == 23 || i == 24)
                    {
                    }
                    else
                    {
                        oPacket.WriteShort(52);
                        oPacket.WriteShort(i);
                        oPacket.WriteShort(0);
                        oPacket.WriteShort(NewRider.Value2);
                        oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                        oPacket.WriteByte(0);
                        oPacket.WriteShort(-1);
                        oPacket.WriteShort(0);
                    }
                }
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void Uniform()
        {
            using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
            {
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                int Uniform = 108;
                oPacket.WriteInt(Uniform - 62);
                for (short i = 1; i <= Uniform; i++)
                {
                    if (i == 15 || i == 18 || i == 20 || i == 21 || i == 23 || i == 26 || i == 31 || i == 32 || i == 33 || i == 34 ||
                        i == 40 || i == 41 || i == 42 || i == 43 || i == 44 || i == 45 || i == 46 || i == 47 || i == 48 || i == 49 ||
                        i == 51 || i == 52 || i == 53 || i == 54 || i == 55 || i == 56 || i == 57 || i == 58 || i == 59 || i == 61 ||
                        i == 62 || i == 63 || i == 64 || i == 65 || i == 66 || i == 67 || i == 68 || i == 69 || i == 70 || i == 71 ||
                        i == 73 || i == 74 || i == 75 || i == 76 || i == 77 || i == 78 || i == 79 || i == 80 || i == 81 || i == 84 ||
                        i == 87 || i == 88 || i == 89 || i == 94 || i == 95 || i == 96 || i == 97 || i == 99 || i == 100 || i == 101 ||
                        i == 102 || i == 108)
                    {
                    }
                    else
                    {
                        oPacket.WriteShort(18);
                        oPacket.WriteShort(i);
                        oPacket.WriteShort(0);
                        oPacket.WriteShort(NewRider.Value2);
                        oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                        oPacket.WriteByte(0);
                        oPacket.WriteShort(-1);
                        oPacket.WriteShort(0);
                    }
                }
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void Aura()
        {
            using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
            {
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                int Aura = 48;
                oPacket.WriteInt(Aura + 1 - 4);
                oPacket.WriteShort(26);
                oPacket.WriteShort(30000);
                oPacket.WriteShort(0);
                oPacket.WriteShort(NewRider.Value2);
                oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                oPacket.WriteByte(0);
                oPacket.WriteShort(-1);
                oPacket.WriteShort(0);
                for (short i = 1; i <= Aura; i++)
                {
                    if (i == 28 || i == 33 || i == 35 || i == 46)
                    {
                    }
                    else
                    {
                        oPacket.WriteShort(26);
                        oPacket.WriteShort(i);
                        oPacket.WriteShort(0);
                        oPacket.WriteShort(NewRider.Value2);
                        oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                        oPacket.WriteByte(0);
                        oPacket.WriteShort(-1);
                        oPacket.WriteShort(0);
                    }
                }
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void SkidMark()
        {
            using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
            {
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                int SkidMark = 23;
                oPacket.WriteInt(SkidMark - 3);
                for (short i = 1; i <= SkidMark; i++)
                {
                    if (i == 14 || i == 20 || i == 21)
                    {
                    }
                    else
                    {
                        oPacket.WriteShort(27);
                        oPacket.WriteShort(i);
                        oPacket.WriteShort(0);
                        oPacket.WriteShort(NewRider.Value2);
                        oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                        oPacket.WriteByte(0);
                        oPacket.WriteShort(-1);
                        oPacket.WriteShort(0);
                    }
                }
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void Plate()
        {
            using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
            {
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                int Plate = 232;
                oPacket.WriteInt(Plate - 102);
                for (short i = 1; i <= Plate; i++)
                {
                    if (i == 57 || i == 66 || i == 67 || i == 68 || i == 75 || i == 78 || i == 80 || i == 81 || i == 88 || i == 92 ||
                        i == 97 || i == 98 || i == 99 || i == 100 || i == 105 || i == 110 || i == 111 || i == 116 || i == 120 || i == 121 ||
                        i == 122 || i == 123 || i == 124 || i == 125 || i == 126 || i == 127 || i == 128 || i == 129 || i == 130 || i == 131 ||
                        i == 133 || i == 134 || i == 139 || i == 140 || i == 141 || i == 143 || i == 146 || i == 147 || i == 148 || i == 149 ||
                        i == 150 || i == 152 || i == 153 || i == 154 || i == 155 || i == 156 || i == 157 || i == 158 || i == 159 || i == 160 ||
                        i == 161 || i == 162 || i == 163 || i == 164 || i == 165 || i == 166 || i == 167 || i == 168 || i == 169 || i == 170 ||
                        i == 171 || i == 172 || i == 173 || i == 174 || i == 175 || i == 176 || i == 177 || i == 178 || i == 179 || i == 180 ||
                        i == 181 || i == 182 || i == 183 || i == 184 || i == 186 || i == 187 || i == 188 || i == 189 || i == 190 || i == 191 ||
                        i == 192 || i == 193 || i == 194 || i == 195 || i == 196 || i == 197 || i == 198 || i == 204 || i == 206 || i == 210 ||
                        i == 211 || i == 212 || i == 214 || i == 215 || i == 216 || i == 217 || i == 218 || i == 221 || i == 227 || i == 228 ||
                        i == 229 || i == 231)
                    {
                    }
                    else
                    {
                        oPacket.WriteShort(4);
                        oPacket.WriteShort(i);
                        oPacket.WriteShort(0);
                        oPacket.WriteShort(NewRider.Value2);
                        oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                        oPacket.WriteByte(0);
                        oPacket.WriteShort(-1);
                        oPacket.WriteShort(0);
                    }
                }
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void Balloon()
        {
            using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
            {
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                oPacket.WriteInt(5 + 78 + 85);
                for (short i = 30009; i <= 30013; i++)
                {
                    oPacket.WriteShort(9);
                    oPacket.WriteShort(i);
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(NewRider.Value1);
                    oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(-1);
                    oPacket.WriteShort(0);
                }
                for (short i = 1; i <= 1047; i++)
                {
                    if (i == 71 || i == 74 || i == 118 || i == 125 || i == 139 || i == 142 || i == 149 || i == 162 || i == 182 || i == 187 ||
                        i == 195 || i == 196 || i == 199 || i == 204 || i == 210 || i == 211 || i == 214 || i == 223 || i == 224 || i == 266 ||
                        i == 272 || i == 279 || i == 296 || i == 298 || i == 299 || i == 304 || i == 305 || i == 308 || i == 310 || i == 311 ||
                        i == 385 || i == 432 || i == 433 || i == 468 || i == 482 || i == 523 || i == 535 || i == 536 || i == 537 || i == 538 ||
                        i == 539 || i == 540 || i == 541 || i == 542 || i == 543 || i == 544 || i == 545 || i == 623 || i == 632 || i == 658 ||
                        i == 670 || i == 781 || i == 798 || i == 799 || i == 817 || i == 846 || i == 868 || i == 880 || i == 904 || i == 957 ||
                        i == 959 || i == 960 || i == 1000 || i == 1001 || i == 1002 || i == 1003 || i == 1004 || i == 1008 || i == 1009 || i == 1010 ||
                        i == 1038 || i == 1039 || i == 1040 || i == 1041 || i == 1042 || i == 1044 || i == 1046 || i == 1047 ||

                        i == 1 || i == 2 || i == 3 || i == 4 || i == 11 || i == 12 || i == 13 || i == 54 || i == 56 || i == 68 ||
                        i == 78 || i == 84 || i == 103 || i == 130 || i == 140 || i == 152 || i == 213 || i == 225 || i == 265 || i == 292 ||
                        i == 318 || i == 323 || i == 350 || i == 351 || i == 378 || i == 444 || i == 445 || i == 446 || i == 447 || i == 448 ||
                        i == 449 || i == 450 || i == 512 || i == 599 || i == 600 || i == 602 || i == 603 || i == 627 || i == 647 || i == 655 ||
                        i == 667 || i == 671 || i == 683 || i == 684 || i == 685 || i == 687 || i == 689 || i == 690 || i == 691 || i == 692 ||
                        i == 695 || i == 697 || i == 705 || i == 730 || i == 745 || i == 746 || i == 747 || i == 756 || i == 768 || i == 790 ||
                        i == 791 || i == 794 || i == 795 || i == 796 || i == 800 || i == 808 || i == 822 || i == 823 || i == 824 || i == 828 ||
                        i == 850 || i == 862 || i == 863 || i == 864 || i == 865 || i == 866 || i == 867 || i == 877 || i == 878 || i == 879 ||
                        i == 882 || i == 883 || i == 969 || i == 970 || i == 1045)
                    {
                        oPacket.WriteShort(9);
                        oPacket.WriteShort(i);
                        oPacket.WriteShort(0);
                        oPacket.WriteShort(NewRider.Value1);
                        oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                        oPacket.WriteByte(0);
                        oPacket.WriteShort(-1);
                        oPacket.WriteShort(0);
                    }
                }
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void Goggle()
        {
            using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
            {
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                int Goggle = 149;
                oPacket.WriteInt(Goggle + 5 - 25);
                for (short i = 30000; i <= 30004; i++)
                {
                    oPacket.WriteShort(8);
                    oPacket.WriteShort(i);
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(NewRider.Value2);
                    oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(-1);
                    oPacket.WriteShort(0);
                }
                for (short i = 1; i <= Goggle; i++)
                {
                    if (i == 7 || i == 8 || i == 13 || i == 28 || i == 33 || i == 36 || i == 41 || i == 43 || i == 49 || i == 51 ||
                        i == 60 || i == 64 || i == 65 || i == 67 || i == 83 || i == 92 || i == 105 || i == 121 || i == 126 || i == 127 ||
                        i == 128 || i == 140 || i == 141 || i == 144 || i == 148)
                    {
                    }
                    else
                    {
                        oPacket.WriteShort(8);
                        oPacket.WriteShort(i);
                        oPacket.WriteShort(0);
                        oPacket.WriteShort(NewRider.Value2);
                        oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                        oPacket.WriteByte(0);
                        oPacket.WriteShort(-1);
                        oPacket.WriteShort(0);
                    }
                }
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void HeadBand()
        {
            using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
            {
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                int HeadBand = 484;
                oPacket.WriteInt(HeadBand + 5 - 42);
                for (short i = 30003; i <= 30007; i++)
                {
                    oPacket.WriteShort(11);
                    oPacket.WriteShort(i);
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(NewRider.Value1);
                    oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(-1);
                    oPacket.WriteShort(0);
                }
                for (short i = 1; i <= HeadBand; i++)
                {
                    if (i == 16 || i == 21 || i == 23 || i == 29 || i == 37 || i == 39 || i == 40 || i == 41 || i == 43 || i == 44 ||
                        i == 46 || i == 59 || i == 60 || i == 62 || i == 63 || i == 67 || i == 70 || i == 79 || i == 89 || i == 118 || 
                        i == 156 || i == 167 || i == 168 || i == 201 || i == 206 || i == 207 || i == 213 || i == 215 || i == 216 || i == 218 || 
                        i == 261 || i == 291 || i == 327 || i == 353 || i == 385 || i == 386 || i == 387 || i == 412 || i == 414 || i == 466 || 
                        i == 467 || i == 468)
                    {
                    }
                    else
                    {
                        oPacket.WriteShort(11);
                        oPacket.WriteShort(i);
                        oPacket.WriteShort(0);
                        oPacket.WriteShort(NewRider.Value1);
                        oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                        oPacket.WriteByte(0);
                        oPacket.WriteShort(-1);
                        oPacket.WriteShort(0);
                    }
                }
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void HandGearL()
        {
            using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
            {
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                int HandGearL = 303;
                oPacket.WriteInt(HandGearL + 6 - 72);
                for (short i = 30002; i <= 30011; i++)
                {
                    if (i == 30007 || i == 30008 || i == 30009 || i == 30010)
                    {
                    }
                    else
                    {
                        oPacket.WriteShort(16);
                        oPacket.WriteShort(i);
                        oPacket.WriteShort(0);
                        oPacket.WriteShort(NewRider.Value2);
                        oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                        oPacket.WriteByte(0);
                        oPacket.WriteShort(-1);
                        oPacket.WriteShort(0);
                    }
                }
                for (short i = 1; i <= HandGearL; i++)
                {
                    if (i == 21 || i == 23 || i == 44 || i == 45 || i == 48 || i == 51 || i == 58 || i == 61 || i == 63 || i == 67 ||
                        i == 69 || i == 71 || i == 86 || i == 90 || i == 96 || i == 100 || i == 101 || i == 118 || i == 119 || i == 120 ||
                        i == 126 || i == 134 || i == 137 || i == 138 || i == 140 || i == 145 || i == 152 || i == 153 || i == 154 || i == 159 ||
                        i == 160 || i == 161 || i == 162 || i == 169 || i == 172 || i == 173 || i == 176 || i == 182 || i == 183 || i == 186 ||
                        i == 189 || i == 190 || i == 195 || i == 196 || i == 197 || i == 199 || i == 201 || i == 202 || i == 203 || i == 204 ||
                        i == 215 || i == 216 || i == 218 || i == 219 || i == 230 || i == 237 || i == 239 || i == 243 || i == 250 || i == 255 ||
                        i == 273 || i == 276 || i == 277 || i == 278 || i == 283 || i == 285 || i == 286 || i == 288 || i == 290 || i == 291 ||
                        i == 292 || i == 293)
                    {
                    }
                    else
                    {
                        oPacket.WriteShort(16);
                        oPacket.WriteShort(i);
                        oPacket.WriteShort(0);
                        oPacket.WriteShort(NewRider.Value2);
                        oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                        oPacket.WriteByte(0);
                        oPacket.WriteShort(-1);
                        oPacket.WriteShort(0);
                    }
                }
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void MyRoom()
        {
            using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
            {
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                int MyRoom = 24;
                oPacket.WriteInt(MyRoom - 12);
                for (short i = 1; i <= MyRoom; i++)
                {
                    if (i == 1 || i == 4 || i == 5 || i == 10 || i == 11 || i == 12 || i == 13 || i == 14 || i == 15 || i == 16 || i == 18 || i == 22)
                    {
                    }
                    else
                    {
                        oPacket.WriteShort(28);
                        oPacket.WriteShort(i);
                        oPacket.WriteShort(0);
                        oPacket.WriteShort(NewRider.Value2);
                        oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                        oPacket.WriteByte(0);
                        oPacket.WriteShort(-1);
                        oPacket.WriteShort(0);
                    }
                }
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void RidColor()
        {
            using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
            {
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                int RidColor = 5;
                oPacket.WriteInt(RidColor);
                for (short i = 1; i <= RidColor; i++)
                {
                    oPacket.WriteShort(31);
                    oPacket.WriteShort(i);
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(NewRider.Value2);
                    oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(-1);
                    oPacket.WriteShort(0);
                }
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void BonusCard()
        {
            using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
            {
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                int BonusCard = 6;
                oPacket.WriteInt(BonusCard);
                for (short i = 1; i <= BonusCard; i++)
                {
                    oPacket.WriteShort(32);
                    oPacket.WriteShort(i);
                    oPacket.WriteShort(0);
                    oPacket.WriteShort(NewRider.Value2);
                    oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(-1);
                    oPacket.WriteShort(0);
                }
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void SlotItem()
        {
            using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
            {
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                oPacket.WriteInt(2);
                short Value = 0;
                for (short i = 1; i <= 2; i++)
                {
                    oPacket.WriteShort(7);
                    oPacket.WriteShort(i);
                    oPacket.WriteShort(0);
                    if (i == 1)
                    {
                        Value = SetRider.SlotChanger;
                    }
                    else
                    {
                        Value = NewRider.Value1;
                    }
                    oPacket.WriteShort(Value);
                    oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                    oPacket.WriteByte(0);
                    oPacket.WriteShort(-1);
                    oPacket.WriteShort(0);
                }
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void RenameRid()
        {
            using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
            {
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                oPacket.WriteShort(23);
                oPacket.WriteShort(1);
                oPacket.WriteShort(0);
                oPacket.WriteShort(NewRider.Value1);
                oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                oPacket.WriteByte(0);
                oPacket.WriteShort(-1);
                oPacket.WriteShort(0);
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void ReplayTicket()
        {
            using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
            {
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                oPacket.WriteShort(13);
                oPacket.WriteShort(1);
                oPacket.WriteShort(0);
                oPacket.WriteShort(NewRider.Value2);
                oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                oPacket.WriteByte(0);
                oPacket.WriteShort(-1);
                oPacket.WriteShort(0);
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void LucciBag()
        {
            using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
            {
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                oPacket.WriteInt(1);
                oPacket.WriteShort(23);
                oPacket.WriteShort(3);
                oPacket.WriteShort(0);
                oPacket.WriteShort(NewRider.Value2);
                oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
                oPacket.WriteByte(0);
                oPacket.WriteShort(-1);
                oPacket.WriteShort(0);
                RouterListener.MySession.Client.Send(oPacket);
            }
        }
    }
}