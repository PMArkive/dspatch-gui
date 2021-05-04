﻿using dspatch.DS;
using dspatch.IO;
using dspatch.Nitro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dspatch
{
    public class DownloadStationPatcher
    {
        public static String title = "HaxxStation";
        public static String subTitle1 = "By Gericom, shutterbug2000";
        public static String subTitle2 = "and Apache Thunder";
        public static String top = "HaxxStation by Gericom,";
        public static String top1 = "shutterbug2000, Apache Thunder";
        private static byte[] haxxStationIconImage =
        {
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x90, 0x61, 0x66, 0x66, 0x69, 0x66, 0x66, 0x66, 0x61, 0xC8, 0xCC, 0xCC,
            0x66, 0xCC, 0xCC, 0x6C, 0x66, 0xCC, 0xCC, 0x6C, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x66, 0x66, 0x66, 0x66,
            0x66, 0x66, 0x66, 0x66, 0xCC, 0xCC, 0xCC, 0xCC, 0x66, 0x66, 0x66, 0x66,
            0x66, 0x66, 0x66, 0x66, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x66, 0x66, 0x16, 0x09, 0x66, 0x66, 0x66, 0x96,
            0xCC, 0xCC, 0x8C, 0x16, 0xC6, 0xCC, 0xCC, 0x66, 0xC6, 0xCC, 0xCC, 0x66,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x66, 0xCC, 0xCC, 0x6C,
            0x66, 0xCC, 0xCC, 0x6C, 0x66, 0xCC, 0xCC, 0x6C, 0x66, 0xCC, 0xCC, 0x6C,
            0x66, 0xCC, 0xCC, 0x6C, 0x66, 0x8C, 0xCC, 0x6C, 0x45, 0x65, 0x41, 0x85,
            0x89, 0xE2, 0xC0, 0x27, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66,
            0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66,
            0x66, 0x66, 0x66, 0x66, 0x27, 0x16, 0x54, 0xB7, 0xD5, 0xE0, 0x9D, 0x14,
            0xC6, 0xCC, 0xCC, 0x66, 0xC6, 0xCC, 0xCC, 0x66, 0xC6, 0xCC, 0xCC, 0x66,
            0xC6, 0xCC, 0xCC, 0x66, 0xC6, 0xCC, 0xCC, 0x66, 0xC6, 0x99, 0xCC, 0x66,
            0x5C, 0x11, 0xC5, 0x66, 0x42, 0xEE, 0x24, 0x44, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x0A, 0x00, 0x00, 0x20, 0x0E, 0x00,
            0x00, 0x79, 0x00, 0x0B, 0x00, 0x01, 0x70, 0x08, 0xD0, 0x04, 0x2E, 0x00,
            0xB0, 0x07, 0x5D, 0x00, 0x00, 0x00, 0x00, 0x00, 0xD9, 0x00, 0x77, 0x0C,
            0x24, 0x87, 0x52, 0x14, 0x66, 0x14, 0xC9, 0x6C, 0x66, 0xAC, 0xCC, 0x6C,
            0x66, 0xCC, 0xC1, 0x6C, 0x66, 0x1C, 0x16, 0x6C, 0x66, 0xCC, 0xC1, 0x6C,
            0x00, 0x00, 0x00, 0x00, 0x80, 0x21, 0xA7, 0x00, 0x41, 0x88, 0x47, 0x41,
            0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0xF3, 0x63, 0x66, 0x66,
            0x36, 0x3F, 0x66, 0x66, 0x36, 0x3F, 0x66, 0x66, 0x0D, 0x00, 0xD0, 0x99,
            0x00, 0x88, 0x00, 0x00, 0x18, 0x44, 0x81, 0x99, 0x76, 0xCC, 0x57, 0x44,
            0xC6, 0xCC, 0xCC, 0x66, 0xC6, 0x6C, 0xCC, 0x66, 0xC6, 0xC6, 0xC6, 0x66,
            0xC6, 0x6C, 0xCC, 0x66, 0x90, 0x09, 0x89, 0x00, 0xB0, 0x07, 0x4D, 0x00,
            0xD0, 0x04, 0x10, 0x00, 0x00, 0x01, 0x80, 0x05, 0x00, 0x78, 0x00, 0x0E,
            0x00, 0x10, 0x0D, 0x00, 0x00, 0x00, 0x08, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x66, 0xCC, 0xCC, 0x6C, 0x66, 0xCC, 0xCC, 0x6C, 0x66, 0xCC, 0xCC, 0x6C,
            0x61, 0xC8, 0xCC, 0xCC, 0x68, 0x66, 0x66, 0x66, 0x80, 0x61, 0x66, 0x66,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xF3, 0x63, 0xFF, 0x6F,
            0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0xCC, 0xCC, 0xCC, 0xCC,
            0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0xC6, 0xCC, 0xCC, 0x66, 0xC6, 0xCC, 0xCC, 0x66,
            0xC6, 0xCC, 0xCC, 0x66, 0xCC, 0xCC, 0x8C, 0x16, 0x66, 0x66, 0x66, 0x86,
            0x66, 0x66, 0x16, 0x08, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
        };

        public static byte[] haxxStationIconPltt =
        {
            0x1F, 0x7C, 0x42, 0x04, 0x83, 0x0C, 0xC5, 0x08, 0xC6, 0x18, 0xE7, 0x1C,
            0x00, 0x00, 0x29, 0x25, 0x8C, 0x2D, 0xAD, 0x35, 0xCE, 0x39, 0x0F, 0x3E,
            0x10, 0x42, 0x51, 0x46, 0x94, 0x52, 0x35, 0x23
        };

        public static byte[] haxxStationServer =
        {
            0x52, 0x43, 0x31, 0x20, 0x32, 0x30, 0x30, 0x36, 0x20, 0x30, 0x31, 0x20,
            0x32, 0x35, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x47, 0x65, 0x72, 0x69,
            0x63, 0x6F, 0x6D, 0x00, 0x00, 0x00, 0x48, 0x61, 0x78, 0x78, 0x53, 0x74,
            0x61, 0x74, 0x69, 0x6F, 0x6E, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x42, 0x79, 0x20, 0x47, 0x65, 0x72,
            0x69, 0x63, 0x6F, 0x6D, 0x2C, 0x20, 0x73, 0x68, 0x75, 0x74, 0x74, 0x65,
            0x72, 0x62, 0x75, 0x67, 0x32, 0x30, 0x30, 0x30, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x61, 0x6E, 0x64, 0x20, 0x41, 0x70,
            0x61, 0x63, 0x68, 0x65, 0x20, 0x54, 0x68, 0x75, 0x6E, 0x64, 0x65, 0x72,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x2E, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00
        };

        private static byte[] exploitData =
        {
            0x44, 0x30, 0x9F, 0xE5, 0x2C, 0x00, 0x93, 0xE5, 0x2C, 0x10, 0x9F, 0xE5,
            0x01, 0x00, 0x40, 0xE0, 0x28, 0x10, 0x9F, 0xE5, 0x01, 0x00, 0x80, 0xE0,
            0x24, 0x10, 0x9F, 0xE5, 0x24, 0x20, 0x9F, 0xE5, 0x28, 0xE0, 0x9F, 0xE5,
            0x3E, 0xFF, 0x2F, 0xE1, 0x24, 0xE0, 0x9F, 0xE5, 0x3E, 0xFF, 0x2F, 0xE1,
            0x01, 0x00, 0xA0, 0xE3, 0x1C, 0xE0, 0x9F, 0xE5, 0x1E, 0xFF, 0x2F, 0xE1,
            0x00, 0xAE, 0x11, 0x00, 0x00, 0x40, 0x00, 0x00, 0x00, 0x00, 0x00, 0x02,
            0x20, 0x6D, 0x11, 0x00, 0x40, 0xE8, 0x3F, 0x02, 0x08, 0xBB, 0x32, 0x02,
            0x24, 0xAF, 0x32, 0x02, 0x78, 0x3A, 0x32, 0x02
        };

        private static byte[] arm7Fix =
        {
            0x2C, 0x00, 0x9F, 0xE5, 0x8E, 0x07, 0x80, 0xE2, 0x1C, 0x10, 0x9F, 0xE5,
            0x1C, 0x20, 0x9F, 0xE5, 0x01, 0x30, 0xD0, 0xE4, 0x01, 0x30, 0xC1, 0xE4,
            0x01, 0x20, 0x52, 0xE2, 0xFB, 0xFF, 0xFF, 0xCA, 0x00, 0x00, 0x9F, 0xE5,
            0x10, 0xFF, 0x2F, 0xE1, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x38, 0x00, 0x00, 0x00
        };

        private NDS mDownloadStation;
        private SFSDirectory mFileSystem;
        private DemoMenu mDemoMenu;

        public DownloadStationPatcher(NDS downloadStation)
        {
            mDownloadStation = downloadStation;
            mFileSystem = mDownloadStation.ToFileSystem();

            SFSDirectory d = mFileSystem.GetDirectoryByPath("//ds_demo");
            //this is shitty...
            d.Files.Remove(d.GetFileByPath("ds_demo/ANDEdemo"));
            d.Files.Remove(d.GetFileByPath("ds_demo/AGFEdemo"));
            d.Files.Remove(d.GetFileByPath("ds_demo/AMFEclip"));
            d.Files.Remove(d.GetFileByPath("ds_demo/AMTEdemo"));
            d.Files.Remove(d.GetFileByPath("ds_demo/APTEdemo"));
            d.Files.Remove(d.GetFileByPath("ds_demo/ATTEdemo"));
            d.Files.Remove(d.GetFileByPath("ds_demo/ATTEpush"));
            d.Files.Remove(d.GetFileByPath("ds_demo/testcode"));
            d.Files.Remove(d.GetFileByPath("ds_demo/AMCEdemo"));

            mFileSystem.GetFileByPath("//mb/server").Data = haxxStationServer;
            mFileSystem.GetFileByPath("//mb/icon.nbfc").Data = haxxStationIconImage;
            mFileSystem.GetFileByPath("//mb/icon.nbfp").Data = haxxStationIconPltt;

            //change banner
            mDownloadStation.Banner.Banner.Image = haxxStationIconImage;
            mDownloadStation.Banner.Banner.Pltt = haxxStationIconPltt;
            String banner = title + "\n" + subTitle1 + "\n" + subTitle2;
            for (int i = 0; i < 6; i++)
                mDownloadStation.Banner.Banner.GameName[i] = banner;

            mDemoMenu = new DemoMenu();
        }

        public void AddRom(NDS rom)
        {
            if (rom.Header.SubRamAddress >= 0x03000000)
            {
                byte[] newArm7 = new byte[rom.SubRom.Length + arm7Fix.Length];
                Array.Copy(arm7Fix, newArm7, arm7Fix.Length);
                Array.Copy(rom.SubRom, 0, newArm7, arm7Fix.Length, rom.SubRom.Length);
                IOUtil.WriteU32LE(newArm7, 0x28, rom.Header.SubEntryAddress);
                IOUtil.WriteU32LE(newArm7, 0x2C, rom.Header.SubRamAddress);
                IOUtil.WriteU32LE(newArm7, 0x30, rom.Header.SubSize);
                rom.SubRom = newArm7;
                rom.Header.SubSize = (uint)newArm7.Length;
                rom.Header.SubRamAddress = 0x02380000;
                rom.Header.SubEntryAddress = 0x02380000;
            }
            byte[] newRomFixed = rom.Write(true);

            uint arm9offset = (uint)(newRomFixed[0x20] | (newRomFixed[0x21] << 8) | (newRomFixed[0x22] << 16) | (newRomFixed[0x23] << 24));
            uint arm9loadaddr = (uint)(newRomFixed[0x28] | (newRomFixed[0x29] << 8) | (newRomFixed[0x2A] << 16) | (newRomFixed[0x2B] << 24));
            uint arm9size = (uint)(newRomFixed[0x2C] | (newRomFixed[0x2D] << 8) | (newRomFixed[0x2E] << 16) | (newRomFixed[0x2F] << 24));
            uint arm7offset = (uint)(newRomFixed[0x30] | (newRomFixed[0x31] << 8) | (newRomFixed[0x32] << 16) | (newRomFixed[0x33] << 24));

            //arm9 offset becomes 0x180
            newRomFixed[0x20] = 0x80;
            newRomFixed[0x21] = 0x01;
            newRomFixed[0x22] = 0x00;
            newRomFixed[0x23] = 0x00;
            //arm9 load becomes 0x02332C40 (rsa_GetDecodedHash)
            newRomFixed[0x28] = 0x40;
            newRomFixed[0x29] = 0x2C;
            newRomFixed[0x2A] = 0x33;
            newRomFixed[0x2B] = 0x02;
            //arm9 size becomes 0x100
            newRomFixed[0x2C] = 0x00;
            newRomFixed[0x2D] = 0x01;
            newRomFixed[0x2E] = 0x00;
            newRomFixed[0x2F] = 0x00;
            ushort newcrc = CRC16.GetCRC16(newRomFixed, 0, 0x15E);
            newRomFixed[0x15E] = (byte)(newcrc & 0xFF);
            newRomFixed[0x15F] = (byte)(newcrc >> 8);

            Array.Copy(exploitData, 0, newRomFixed, 0x180, exploitData.Length);

            newRomFixed[0x180 + 0x3C] = (byte)(arm7offset & 0xFF);
            newRomFixed[0x180 + 0x3D] = (byte)((arm7offset >> 8) & 0xFF);
            newRomFixed[0x180 + 0x3E] = (byte)((arm7offset >> 16) & 0xFF);
            newRomFixed[0x180 + 0x3F] = (byte)((arm7offset >> 24) & 0xFF);

            newRomFixed[0x180 + 0x40] = (byte)(arm9offset & 0xFF);
            newRomFixed[0x180 + 0x41] = (byte)((arm9offset >> 8) & 0xFF);
            newRomFixed[0x180 + 0x42] = (byte)((arm9offset >> 16) & 0xFF);
            newRomFixed[0x180 + 0x43] = (byte)((arm9offset >> 24) & 0xFF);

            newRomFixed[0x180 + 0x44] = (byte)(arm9loadaddr & 0xFF);
            newRomFixed[0x180 + 0x45] = (byte)((arm9loadaddr >> 8) & 0xFF);
            newRomFixed[0x180 + 0x46] = (byte)((arm9loadaddr >> 16) & 0xFF);
            newRomFixed[0x180 + 0x47] = (byte)((arm9loadaddr >> 24) & 0xFF);

            newRomFixed[0x180 + 0x48] = (byte)(arm9size & 0xFF);
            newRomFixed[0x180 + 0x49] = (byte)((arm9size >> 8) & 0xFF);
            newRomFixed[0x180 + 0x4A] = (byte)((arm9size >> 16) & 0xFF);
            newRomFixed[0x180 + 0x4B] = (byte)((arm9size >> 24) & 0xFF);

            string fileName = "rom" + mDemoMenu.entries.Count.ToString("0000") + "d";

            var entry = new DemoMenu.DemoMenuEntry()
            {
                rating = 1,
                guideMode = 0x15,
                touchText1 = top,
                touchText2 = top1,
                internalName = fileName
            };
            if (rom.Banner != null)
            {
                string[] lines = rom.Banner.Banner.GameName[1].Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                if (lines.Length > 0)
                    entry.bannerText1 = lines[0];
                else
                    entry.bannerText1 = "Bannerless Homebrew";
                if (lines.Length > 1)
                    entry.bannerText2 = lines[1];
                else
                    entry.bannerText2 = "";
                entry.bannerImage = rom.Banner.Banner.Image;
                entry.bannerPalette = rom.Banner.Banner.Pltt;
            }
            else
            {
                entry.bannerText1 = "Bannerless Homebrew";
                entry.bannerText2 = "";
                entry.bannerImage = new byte[512];
                entry.bannerPalette = new byte[32];
            }
            mDemoMenu.entries.Add(entry);
            var d = mFileSystem.GetDirectoryByPath("//ds_demo");
            d.Files.Add(new SFSFile(-1, fileName, d) { Data = newRomFixed });

        }


        // Turns a rom into a menu entry, will be hijacked at some point to allow setting custom names and icons.
        public NDS ProduceRom()
        {
            string fileName = "rom" + (mDemoMenu.entries.Count - 1).ToString("0000") + "d";
            while (mDemoMenu.entries.Count < 3)
            {
                mDemoMenu.entries.Add(new DemoMenu.DemoMenuEntry()
                {
                    bannerImage = new byte[512],
                    bannerPalette = new byte[32],
                    bannerText1 = "",
                    bannerText2 = "",
                    rating = 1,
                    guideMode = 0x15,
                    touchText1 = top,
                    touchText2 = top1,
                    internalName = fileName
                });
            }
            mFileSystem.GetFileByPath("//ds_demo/demomenu").Data = mDemoMenu.Write();
            mDownloadStation.FromFileSystem(mFileSystem);
            return mDownloadStation;
        }


        // This is used to make sure that it is accurate, should be changed. Very terrible code, very messy.
        public static void HaxxStationServerName(Byte[] _name)
        {
            haxxStationServer = _name;
        }

        // Receives the name in ASCII and converts it into bytes which then sets it.
        public static void HaxxStationServerName(String _name)
        {
            byte[] nameByte = Encoding.ASCII.GetBytes(_name);
            haxxStationServer = nameByte;
        }

        // Receives the banner modification that the user placed, and then sets it.
        // Please keep it within the same amount of characters there.
        public static void HaxxStationBanner(String _title, String _subTitle1, String _subTitle2)
        {
            title = _title;
            subTitle1 = _subTitle1;
            subTitle2 = _subTitle2;
        }
        
        // Receives the 2 strings that the user described for the HaxxStation and sets it.
        public static void HaxxStationTop(String _top, String _top1)
        {
            top = _top;
            top1 = _top1;
        }

        // Converts string received into a byte array, which then sets it as the palette.
        public static void HaxxStationIconPltt(String _pltt)
        {
            byte[] plttByte = Encoding.ASCII.GetBytes(_pltt);
            haxxStationIconPltt = plttByte;
        }

        // Converts string received into a byte array, which then sets it as the icon.
        public static void HaxxStationIcon(String _icon)
        {
            byte[] iconByte = Encoding.ASCII.GetBytes(_icon);
            haxxStationIconImage = iconByte;
        }
    }

}
