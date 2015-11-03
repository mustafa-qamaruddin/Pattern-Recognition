﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patterns_Recognition___Task_1
{
    public partial class Form_Task_1 : Form
    {
        public Form_Task_1()
        {
            InitializeComponent();
        }

        private void button_pr_load_img_file_Click(object sender, EventArgs e)
        {
            ImageFilesHandler img_files_handler = new ImageFilesHandler();
            img_files_handler.ignite(this, picture_box_pr, text_box_pr_img_src);
        }

        private void button_open_test_normal_distribution_form_Click(object sender, EventArgs e)
        {
            Form obj_form_test_normal_distribution = new Form_Task_1_Test_Normal_Distribution();
            obj_form_test_normal_distribution.Show(this);
        }

        private void button_split_paint_rects_Click(object sender, EventArgs e)
        {
            Form obj_form_split_paint_rects = new Form_Task_1_b();
            obj_form_split_paint_rects.Show();
        }
    }
}
