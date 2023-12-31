﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using KartRider;

namespace Set_Data
{
    public static class SetRider
    {
        public static string UserID = "speed7075";
        public static uint UserNO = 184810911;
        public static string Nickname = "LAON";
        public static string RiderIntro = "";
        public static short Emblem1 = 0;
        public static short Emblem2 = 0;
        public static uint Lucci = 1000000;
        public static int RP = 10000000;
        public static uint Koin = 10000;
        public static short SlotChanger = 30000;
        public static uint pmap = 0;//3130 //1068 //2520

        public static void Save_SetRider()
        {
            using (StreamWriter streamWriter = new StreamWriter(FileName.SetRider_LoadFile + FileName.SetRider_Nickname + FileName.Extension, false))
            {
                streamWriter.Write(SetRider.Nickname);
            }
            using (StreamWriter streamWriter = new StreamWriter(FileName.SetRider_LoadFile + FileName.SetRider_RiderIntro + FileName.Extension, false))
            {
                streamWriter.Write(SetRider.RiderIntro);
            }
            using (StreamWriter streamWriter = new StreamWriter(FileName.SetRider_LoadFile + FileName.SetRider_Emblem1 + FileName.Extension, false))
            {
                streamWriter.Write(SetRider.Emblem1);
            }
            using (StreamWriter streamWriter = new StreamWriter(FileName.SetRider_LoadFile + FileName.SetRider_Emblem2 + FileName.Extension, false))
            {
                streamWriter.Write(SetRider.Emblem2);
            }
            using (StreamWriter streamWriter = new StreamWriter(FileName.SetRider_LoadFile + FileName.SetRider_Lucci + FileName.Extension, false))
            {
                streamWriter.Write(SetRider.Lucci);
            }
            using (StreamWriter streamWriter = new StreamWriter(FileName.SetRider_LoadFile + FileName.SetRider_RP + FileName.Extension, false))
            {
                streamWriter.Write(SetRider.RP);
            }
            using (StreamWriter streamWriter = new StreamWriter(FileName.SetRider_LoadFile + FileName.SetRider_Koin + FileName.Extension, false))
            {
                streamWriter.Write(SetRider.Koin);
            }
            using (StreamWriter streamWriter = new StreamWriter(FileName.SetRider_LoadFile + FileName.SetRider_SlotChanger + FileName.Extension, false))
            {
                streamWriter.Write(SetRider.SlotChanger);
            }
        }

        public static void Load_SetRider()
        {
            string Load_Nickname = FileName.SetRider_LoadFile + FileName.SetRider_Nickname + FileName.Extension;
            if (File.Exists(Load_Nickname))
            {
                string textValue = System.IO.File.ReadAllText(Load_Nickname);
                SetRider.Nickname = textValue;
            }
            else
            {
                using (StreamWriter streamWriter = new StreamWriter(Load_Nickname, false))
                {
                    streamWriter.Write(SetRider.Nickname);
                }
            }
            //-------------------------------------------------------------------------
            string Load_RiderIntro = FileName.SetRider_LoadFile + FileName.SetRider_RiderIntro + FileName.Extension;
            if (File.Exists(Load_RiderIntro))
            {
                string textValue = System.IO.File.ReadAllText(Load_RiderIntro);
                SetRider.RiderIntro = textValue;
            }
            else
            {
                using (StreamWriter streamWriter = new StreamWriter(Load_RiderIntro, false))
                {
                    streamWriter.Write(SetRider.RiderIntro);
                }
            }
            //-------------------------------------------------------------------------
            string Load_Emblem1 = FileName.SetRider_LoadFile + FileName.SetRider_Emblem1 + FileName.Extension;
            if (File.Exists(Load_Emblem1))
            {
                string textValue = System.IO.File.ReadAllText(Load_Emblem1);
                SetRider.Emblem1 = short.Parse(textValue);
            }
            else
            {
                using (StreamWriter streamWriter = new StreamWriter(Load_Emblem1, false))
                {
                    streamWriter.Write(SetRider.Emblem1);
                }
            }
            //-------------------------------------------------------------------------
            string Load_Emblem2 = FileName.SetRider_LoadFile + FileName.SetRider_Emblem2 + FileName.Extension;
            if (File.Exists(Load_Emblem2))
            {
                string textValue = System.IO.File.ReadAllText(Load_Emblem2);
                SetRider.Emblem2 = short.Parse(textValue);
            }
            else
            {
                using (StreamWriter streamWriter = new StreamWriter(Load_Emblem2, false))
                {
                    streamWriter.Write(SetRider.Emblem2);
                }
            }
            //-------------------------------------------------------------------------
            string Load_Lucci = FileName.SetRider_LoadFile + FileName.SetRider_Lucci + FileName.Extension;
            if (File.Exists(Load_Lucci))
            {
                string textValue = System.IO.File.ReadAllText(Load_Lucci);
                SetRider.Lucci = uint.Parse(textValue);
                if (SetRider.Lucci > SessionGroup.LucciMax)
                {
                    SetRider.Lucci = SessionGroup.LucciMax;
                    using (StreamWriter streamWriter = new StreamWriter(Load_Lucci, false))
                    {
                        streamWriter.Write(SessionGroup.LucciMax);
                    }
                }
            }
            else
            {
                using (StreamWriter streamWriter = new StreamWriter(Load_Lucci, false))
                {
                    streamWriter.Write(SetRider.Lucci);
                }
            }
            //-------------------------------------------------------------------------
            string Load_RP = FileName.SetRider_LoadFile + FileName.SetRider_RP + FileName.Extension;
            if (File.Exists(Load_RP))
            {
                string textValue = System.IO.File.ReadAllText(Load_RP);
                SetRider.RP = int.Parse(textValue);
            }
            else
            {
                using (StreamWriter streamWriter = new StreamWriter(Load_RP, false))
                {
                    streamWriter.Write(SetRider.RP);
                }
            }
            //-------------------------------------------------------------------------
            string Load_Koin = FileName.SetRider_LoadFile + FileName.SetRider_Koin + FileName.Extension;
            if (File.Exists(Load_Koin))
            {
                string textValue = System.IO.File.ReadAllText(Load_Koin);
                SetRider.Koin = uint.Parse(textValue);
            }
            else
            {
                using (StreamWriter streamWriter = new StreamWriter(Load_Koin, false))
                {
                    streamWriter.Write(SetRider.Koin);
                }
            }
            //-------------------------------------------------------------------------
            string Load_SlotChanger = FileName.SetRider_LoadFile + FileName.SetRider_SlotChanger + FileName.Extension;
            if (File.Exists(Load_SlotChanger))
            {
                string textValue = System.IO.File.ReadAllText(Load_SlotChanger);
                SetRider.SlotChanger = short.Parse(textValue);
            }
            else
            {
                using (StreamWriter streamWriter = new StreamWriter(Load_SlotChanger, false))
                {
                    streamWriter.Write(SetRider.SlotChanger);
                }
            }
        }
    }
}