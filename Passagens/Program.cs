using System;
using System.Windows.Forms; // Importante para o MessageBox

namespace Passagens
{
    public class Program
    {
        [STAThread] // Necessário para usar componentes de interface como MessageBox
        static void Main()
        {
            // O comando deve estar EXATAMENTE aqui dentro
            MessageBox.Show("Olá mundo!", "Sucesso");
        }
    }
}
