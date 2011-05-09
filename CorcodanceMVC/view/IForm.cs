using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Concordance.view
{
    public interface IForm
    {
        /// <summary>
        /// Заголовок формы
        /// </summary>
        string Text { get; set; }
        /// <summary>
        /// Вызывает окно открытия или сохранения файла
        /// </summary>
        string ShowFileDialog(FileDialog dialog, string title, string filepattern, bool CheckFileExists = true);
        /// <summary>
        /// Отображает стандартное сообщение об ошибке / информации и пр.
        /// </summary>
        DialogResult ShowMessage(string message, string title = "Error", MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.Error);
    }
}
