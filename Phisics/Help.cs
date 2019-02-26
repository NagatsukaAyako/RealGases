using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phisics
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
            label1.Text = "1. Выбрать газ.\n\r2. Поднять поршень (вернуть в исходное положение).\n\r3. Остановить поршень.\n\r4. Опустить поршень.\n\r5. Поршень.\n\r6. Цилиндр с газом. \n\r7. Шкала (цена деления - 0.2 л).\n\r8. Температура. \n\r9. Давление.\n\r10. Изменить температуру\n\r11. Установить шаг изменения температуры.\n\r12. Включить/выключить";
        }
    }
}
