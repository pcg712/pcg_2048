﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pcg_2048
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

        }
        private List<Bitmap> oBitmap = new List<Bitmap>();

        private Font fFontS2 = new Font("Clear Sans", 10, FontStyle.Bold);
        private Font fFontS = new Font("Clear Sans", 12, FontStyle.Bold);
        private Font fFont = new Font("Clear Sans", 22, FontStyle.Bold);
        private int Lscore = 0, Lbest = 0;
        private int[,] num = new int[,] { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
        private Random r = new Random();
        private void reSet()
        {
            Lscore = 0;
            num = new int[,] { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
            ranNum();
            ranNum();
            this.KeyPreview = true;
        }
        private void ranNum()
        {
            int i = r.Next(0, 4);
            int j = r.Next(0, 4);
            while (num[i, j] != 0)
            {
                i = r.Next(0, 4);
                j = r.Next(0, 4);
            }
            int k = r.Next(1, 11);
            if (k > 1) num[i, j] = 2;
            else num[i, j] = 4;
        }
        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            int[,] n = new int[4, 4];
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    n[i, j] = num[i, j];
            switch (e.KeyCode)
            {
                //W ↑ 向上
                case Keys.Up:
                case Keys.W: goUp(); break;
                //S ↓ 向下
                case Keys.Down:
                case Keys.S: goDown(); break;
                //A ← 向左
                case Keys.Left:
                case Keys.A: goLeft(); break;
                //D → 向右
                case Keys.Right:
                case Keys.D: goRight(); break;

                default: break;
            }
            if ((!ifFull()) && ifRan(n)) ranNum();
            Draw();
            if (!ifRun()) GameOver();
        }
        private Boolean ifRan(int[,] n)
        {
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    if (n[i, j] != num[i, j])
                        return true;
                }
            return false;
        }
        private void goLeft()
        {
            for (int i = 0; i < 4; i++)
            {
                int k = 0;
                while (num[i, 0] == 0 && k < 3)
                {
                    num[i, 0] = num[i, 1];
                    num[i, 1] = num[i, 2];
                    num[i, 2] = num[i, 3];
                    num[i, 3] = 0;
                    k++;
                }
                k = 0;
                while (num[i, 1] == 0 && k < 2)
                {
                    num[i, 1] = num[i, 2];
                    num[i, 2] = num[i, 3];
                    num[i, 3] = 0;
                    k++;
                }
                if (num[i, 2] == 0)
                {
                    num[i, 2] = num[i, 3];
                    num[i, 3] = 0;
                }
                for (k = 0; k < 3; k++)
                {
                    if (num[i, k] == num[i, k + 1])
                    {
                        num[i, k] *= 2;
                        num[i, k + 1] = 0;
                        Lscore += num[i, k];
                    }
                }
                k = 0;
                while (num[i, 0] == 0 && k < 3)
                {
                    num[i, 0] = num[i, 1];
                    num[i, 1] = num[i, 2];
                    num[i, 2] = num[i, 3];
                    num[i, 3] = 0;
                    k++;
                }
                k = 0;
                while (num[i, 1] == 0 && k < 2)
                {
                    num[i, 1] = num[i, 2];
                    num[i, 2] = num[i, 3];
                    num[i, 3] = 0;
                    k++;
                }
                if (num[i, 2] == 0)
                {
                    num[i, 2] = num[i, 3];
                    num[i, 3] = 0;
                }
            }
        }
        private void goRight()
        {
            for (int i = 0; i < 4; i++)
            {
                int k = 0;
                while (num[i, 3] == 0 && k < 3)
                {
                    num[i, 3] = num[i, 2];
                    num[i, 2] = num[i, 1];
                    num[i, 1] = num[i, 0];
                    num[i, 0] = 0;
                    k++;
                }
                k = 0;
                while (num[i, 2] == 0 && k < 2)
                {
                    num[i, 2] = num[i, 1];
                    num[i, 1] = num[i, 0];
                    num[i, 0] = 0;
                    k++;
                }
                if (num[i, 1] == 0)
                {
                    num[i, 1] = num[i, 0];
                    num[i, 0] = 0;
                }
                for (k = 3; k > 0; k--)
                {
                    if (num[i, k] == num[i, k - 1])
                    {
                        num[i, k] *= 2;
                        num[i, k - 1] = 0;
                        Lscore += num[i, k];
                    }
                }
                k = 0;
                while (num[i, 3] == 0 && k < 3)
                {
                    num[i, 3] = num[i, 2];
                    num[i, 2] = num[i, 1];
                    num[i, 1] = num[i, 0];
                    num[i, 0] = 0;
                    k++;
                }
                k = 0;
                while (num[i, 2] == 0 && k < 2)
                {
                    num[i, 2] = num[i, 1];
                    num[i, 1] = num[i, 0];
                    num[i, 0] = 0;
                    k++;
                }
                if (num[i, 1] == 0)
                {
                    num[i, 1] = num[i, 0];
                    num[i, 0] = 0;
                }
            }
        }
        private void goUp()
        {
            for (int i = 0; i < 4; i++)
            {
                int k = 0;
                while (num[0, i] == 0 && k < 3)
                {
                    num[0, i] = num[1, i];
                    num[1, i] = num[2, i];
                    num[2, i] = num[3, i];
                    num[3, i] = 0;
                    k++;
                }
                k = 0;
                while (num[1, i] == 0 && k < 2)
                {
                    num[1, i] = num[2, i];
                    num[2, i] = num[3, i];
                    num[3, i] = 0;
                    k++;
                }
                if (num[2, i] == 0)
                {
                    num[2, i] = num[3, i];
                    num[3, i] = 0;
                }
                for (k = 0; k < 3; k++)
                {
                    if (num[k, i] == num[k + 1, i])
                    {
                        num[k, i] *= 2;
                        num[k + 1, i] = 0;
                        Lscore += num[k, i];
                    }
                }
                k = 0;
                while (num[0, i] == 0 && k < 3)
                {
                    num[0, i] = num[1, i];
                    num[1, i] = num[2, i];
                    num[2, i] = num[3, i];
                    num[3, i] = 0;
                    k++;
                }
                k = 0;
                while (num[1, i] == 0 && k < 2)
                {
                    num[1, i] = num[2, i];
                    num[2, i] = num[3, i];
                    num[3, i] = 0;
                    k++;
                }
                if (num[2, i] == 0)
                {
                    num[2, i] = num[3, i];
                    num[3, i] = 0;
                }
            }
        }
        private void goDown()
        {
            for (int i = 0; i < 4; i++)
            {
                int k = 0;
                while (num[3, i] == 0 && k < 3)
                {
                    num[3, i] = num[2, i];
                    num[2, i] = num[1, i];
                    num[1, i] = num[0, i];
                    num[0, i] = 0;
                    k++;
                }
                k = 0;
                while (num[2, i] == 0 && k < 2)
                {
                    num[2, i] = num[1, i];
                    num[1, i] = num[0, i];
                    num[0, i] = 0;
                    k++;
                }
                if (num[1, i] == 0)
                {
                    num[1, i] = num[0, i];
                    num[0, i] = 0;
                }
                for (k = 3; k > 0; k--)
                {
                    if (num[k, i] == num[k - 1, i])
                    {
                        num[k, i] *= 2;
                        num[k - 1, i] = 0;
                        Lscore += num[k, i];
                    }
                }
                k = 0;
                while (num[3, i] == 0 && k < 3)
                {
                    num[3, i] = num[2, i];
                    num[2, i] = num[1, i];
                    num[1, i] = num[0, i];
                    num[0, i] = 0;
                    k++;
                }
                k = 0;
                while (num[2, i] == 0 && k < 2)
                {
                    num[2, i] = num[1, i];
                    num[1, i] = num[0, i];
                    num[0, i] = 0;
                    k++;
                }
                if (num[1, i] == 0)
                {
                    num[1, i] = num[0, i];
                    num[0, i] = 0;
                }
            }
        }
        private Boolean ifFull()
        {
            Boolean flag = true;
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    if (num[i, j] == 0)
                    {
                        flag = false;
                        break;
                    }
                }
            return flag;
        }
        private Boolean ifRun()
        {
            if (!ifFull()) return true;
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 3; j++)
                {
                    if (num[i, j] == num[i, j + 1])
                        return true;
                }
            for (int i = 0; i < 4; i++)
                for (int j = 3; j > 0; j--)
                {
                    if (num[i, j] == num[i, j - 1])
                        return true;
                }
            for (int j = 0; j < 4; j++)
                for (int i = 0; i < 3; i++)
                {
                    if (num[i, j] == num[i + 1, j])
                        return true;
                }
            for (int j = 0; j < 4; j++)
                for (int i = 3; i > 0; i--)
                {
                    if (num[i, j] == num[i - 1, j])
                        return true;
                }
            return false;
        }
        public int ChooseImg(int a)
        {
            switch (a)
            {
                case 0: return 4;
                case 2: return 5;
                case 4: return 6;
                case 8: return 7;
                case 16: return 8;
                case 32: return 9;
                case 64: return 10;
                case 128: return 11;
                case 256: return 12;
                case 512: return 13;
                case 1024: return 14;
                case 2048: return 15;
                case 4096: return 16;
                case 8192: return 17;
            }
            return 0;
        }

        private void Draw()
        {
            if (num[0, 0] != 0)
                l11.Text = num[0, 0].ToString();
            else l11.Text = "";
            l11.Image = oBitmap[ChooseImg(num[0, 0])];
            if (num[0, 1] != 0)
                l12.Text = num[0, 1].ToString();
            else l12.Text = "";
            l12.Image = oBitmap[ChooseImg(num[0, 1])];
            if (num[0, 2] != 0)
                l13.Text = num[0, 2].ToString();
            else l13.Text = "";
            l13.Image = oBitmap[ChooseImg(num[0, 2])];
            if (num[0, 3] != 0)
                l14.Text = num[0, 3].ToString();
            else l14.Text = "";
            l14.Image = oBitmap[ChooseImg(num[0, 3])];
            if (num[1, 0] != 0)
                l21.Text = num[1, 0].ToString();
            else l21.Text = "";
            l21.Image = oBitmap[ChooseImg(num[1, 0])];
            if (num[1, 1] != 0)
                l22.Text = num[1, 1].ToString();
            else l22.Text = "";
            l22.Image = oBitmap[ChooseImg(num[1, 1])];
            if (num[1, 2] != 0)
                l23.Text = num[1, 2].ToString();
            else l23.Text = "";
            l23.Image = oBitmap[ChooseImg(num[1, 2])];
            if (num[1, 3] != 0)
                l24.Text = num[1, 3].ToString();
            else l24.Text = "";
            l24.Image = oBitmap[ChooseImg(num[1, 3])];
            if (num[2, 0] != 0)
                l31.Text = num[2, 0].ToString();
            else l31.Text = "";
            l31.Image = oBitmap[ChooseImg(num[2, 0])];
            if (num[2, 1] != 0)
                l32.Text = num[2, 1].ToString();
            else l32.Text = "";
            l32.Image = oBitmap[ChooseImg(num[2, 1])];
            if (num[2, 2] != 0)
                l33.Text = num[2, 2].ToString();
            else l33.Text = "";
            l33.Image = oBitmap[ChooseImg(num[2, 2])];
            if (num[2, 3] != 0)
                l34.Text = num[2, 3].ToString();
            else l34.Text = "";
            l34.Image = oBitmap[ChooseImg(num[2, 3])];
            if (num[3, 0] != 0)
                l41.Text = num[3, 0].ToString();
            else l41.Text = "";
            l41.Image = oBitmap[ChooseImg(num[3, 0])];
            if (num[3, 1] != 0)
                l42.Text = num[3, 1].ToString();
            else l42.Text = "";
            l42.Image = oBitmap[ChooseImg(num[3, 1])];
            if (num[3, 2] != 0)
                l43.Text = num[3, 2].ToString();
            else l43.Text = "";
            l43.Image = oBitmap[ChooseImg(num[3, 2])];
            if (num[3, 3] != 0)
                l44.Text = num[3, 3].ToString();
            else l44.Text = "";
            l44.Image = oBitmap[ChooseImg(num[3, 3])];
            score.Text = Lscore.ToString();
        }
        private async void Rank(int _score)
        {
            HttpClient httpClient = new HttpClient();
            string url = "http://39.97.183.140:80/api/rank";
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("score", _score.ToString()));
            try
            {
                var response = await httpClient.PostAsync(new Uri(url), new FormUrlEncodedContent(parameters));
                var result = await response.Content.ReadAsStringAsync();
                if (result.Equals("no rank")) MessageBox.Show("游戏结束，你的分数是：" + Lscore + "\n由于网络异常无法获取你的全球排名！");
                else MessageBox.Show("游戏结束，你的分数是：" + Lscore + "\n你的全球排名为：" + result + "！");
            }
            catch (System.Net.Http.HttpRequestException)
            {
                MessageBox.Show("游戏结束，你的分数是：" + Lscore + "\n由于网络异常无法获取你的全球排名！");
            }

        }

        private void GameOver()
        {
            Rank(Lscore);
            //MessageBox.Show("游戏结束，你的分数是：" + Lscore);
            if (Lbest < Lscore) Lbest = Lscore;
            best.Text = Lbest.ToString();
            this.KeyPreview = false;
        }
        private void Main_Load(object sender, EventArgs e)
        {
            score.Font = fFontS;
            best.Font = fFontS;
            l11.Font = fFontS;
            l12.Font = fFontS;
            l13.Font = fFontS;
            l14.Font = fFontS;
            l21.Font = fFontS;
            l22.Font = fFontS;
            l23.Font = fFontS;
            l24.Font = fFontS;
            l31.Font = fFontS;
            l32.Font = fFontS;
            l33.Font = fFontS;
            l34.Font = fFontS;
            l41.Font = fFontS;
            l42.Font = fFontS;
            l43.Font = fFontS;
            l44.Font = fFontS;
            oBitmap.Add(Properties.Resources._1);
            oBitmap.Add(Properties.Resources._2);
            oBitmap.Add(Properties.Resources._3);
            oBitmap.Add(Properties.Resources._4);
            oBitmap.Add(Properties.Resources._5);
            oBitmap.Add(Properties.Resources._6);
            oBitmap.Add(Properties.Resources._7);
            oBitmap.Add(Properties.Resources._8);
            oBitmap.Add(Properties.Resources._9);
            oBitmap.Add(Properties.Resources._10);
            oBitmap.Add(Properties.Resources._11);
            oBitmap.Add(Properties.Resources._12);
            oBitmap.Add(Properties.Resources._13);
            oBitmap.Add(Properties.Resources._14);
            oBitmap.Add(Properties.Resources._15);
            oBitmap.Add(Properties.Resources._16);
            oBitmap.Add(Properties.Resources._17);
            oBitmap.Add(Properties.Resources._18);
            oBitmap.Add(Properties.Resources.k0);
            reSet();
            Draw();
        }

        private void start_Click(object sender, EventArgs e)
        {
            reSet();
            Draw();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Up)
                return base.ProcessDialogKey(Keys.W);
            else if (keyData == Keys.Left)
                return base.ProcessDialogKey(Keys.A);
            else if (keyData == Keys.Down)
                return base.ProcessDialogKey(Keys.S);
            else if (keyData == Keys.Right)
                return base.ProcessDialogKey(Keys.D);
            else
                return base.ProcessDialogKey(keyData);
        }
    }
}