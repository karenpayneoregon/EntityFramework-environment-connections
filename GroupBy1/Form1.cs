using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GroupBy1.Contexts;

namespace GroupBy1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            using (var context = new Context())
            {
                var results = context.DemoTable.AsEnumerable()
                    .Where(demoTable => demoTable.Number > 0 && demoTable.Mark2 >0)
                    .GroupBy(item => item.Number)
                    .Select(g => new
                    {
                        Key = g.Key,
                        Model = g.Select(demoTable => demoTable).ToList()
                    }).ToList();

                foreach (var result in results)
                {
                    Console.WriteLine(result.Key);
                    foreach (var model in result.Model)
                    {
                        Console.WriteLine($" {model.Id}, {model.Quantity1}, {model.Mark2}");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
  
}
