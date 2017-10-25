using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R440O.LearnModule
{
    public class HighLightModule
    {
        Button element;
        CancellationTokenSource ct = new CancellationTokenSource();

        public HighLightModule(Button element)
        {
            this.element = element;
        }

        public async void HighLighting ()
        {
           try
           {
             await PlaySuccessAnimation(element, ct.Token);
           } catch { }
          
        }

        public void StopHighLight ()
        {
            ct.Cancel();
        }



        async Task PlaySuccessAnimation(Button b, CancellationToken ct)
        {
            // проверка
            if (b.UseVisualStyleBackColor == true)
                throw new InvalidOperationException("Need overridable color");

            var origColor = b.BackColor;

            var on = TimeSpan.FromSeconds(0.1);
            try
            {
                while (true)
                {
                    // 2 раза по 0.2 секунды
                    await Blink(b, Color.FromArgb(150, 197, 232, 0), on, TimeSpan.FromSeconds(0.3), 2, ct);
                    ct.ThrowIfCancellationRequested();
                }
            }
            catch (OperationCanceledException ex)
            {
                b.BackColor = origColor;
                throw;
            }
        }

        async Task Blink(Button b, Color color,TimeSpan on, TimeSpan off, int n, CancellationToken ct)
    {
        
            var origColor = b.BackColor;
        for (int i = 0; i < n; i++)
        {
            b.BackColor = color;
            await Task.Delay(on, ct);
            b.BackColor = origColor;
            await Task.Delay(off, ct);
        }
    }
}
}
