namespace R440O.R440OForms.DAB_5
{
    using System.Windows.Forms;
    using Parameters;
    /// <summary>
    /// Форма блока ДАБ-5
    /// </summary>
    public partial class DAB_5Form : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="DAB_5Form"/>
        /// </summary>
        public DAB_5Form()
        {
            this.InitializeComponent();
            this.InitializeLamps();
        }

        private void InitializeLamps()
        {
            DAB_5ЛампочкаВыборПрмПрд2.BackgroundImage = DAB_5Parameters.DAB_5ЛампочкаВыборПрмПрд2 ? ControlElementImages.lampType1OnRed : null;
            DAB_5ЛампочкаРежимПрмПрд2К.BackgroundImage = DAB_5Parameters.DAB_5ЛампочкаРежимПрмПрд2К ? ControlElementImages.lampType1OnRed : null;
            DAB_5ЛампочкаРежимПрд2К.BackgroundImage = DAB_5Parameters.DAB_5ЛампочкаРежимПрд2К ? ControlElementImages.lampType1OnRed : null;
            DAB_5ЛампочкаРежимПрд1К.BackgroundImage = DAB_5Parameters.DAB_5ЛампочкаРежимПрд1К ? ControlElementImages.lampType1OnRed : null;
            DAB_5ЛампочкаРежимПрмПрд1К.BackgroundImage = DAB_5Parameters.DAB_5ЛампочкаРежимПрмПрд1К ? ControlElementImages.lampType1OnRed : null;
            DAB_5ЛампочкаРежимШлейф1К.BackgroundImage = DAB_5Parameters.DAB_5ЛампочкаРежимШлейф1К ? ControlElementImages.lampType1OnRed : null;

            DAB_5ЛампочкаРежимШлейф2К.BackgroundImage = DAB_5Parameters.DAB_5ЛампочкаРежимШлейф2К ? ControlElementImages.lampType1OnRed : null;
            DAB_5ЛампочкаРежимРабота2К.BackgroundImage = DAB_5Parameters.DAB_5ЛампочкаРежимРабота2К ? ControlElementImages.lampType1OnRed : null;
            DAB_5ЛампочкаРежимРабота1К.BackgroundImage = DAB_5Parameters.DAB_5ЛампочкаРежимРабота1К ? ControlElementImages.lampType1OnRed : null;
            DAB_5ЛампочкаВыборБП2.BackgroundImage = DAB_5Parameters.DAB_5ЛампочкаВыборБП2 ? ControlElementImages.lampType1OnRed : null;
            DAB_5ЛампочкаВыборБП1.BackgroundImage = DAB_5Parameters.DAB_5ЛампочкаВыборБП1 ? ControlElementImages.lampType1OnRed : null;
            DAB_5ЛампочкаВыборПрмПрд1.BackgroundImage = DAB_5Parameters.DAB_5ЛампочкаВыборПрмПрд1 ? ControlElementImages.lampType1OnRed : null;

            DAB_5ЛампочкаНеиспрБП5.BackgroundImage = DAB_5Parameters.DAB_5ЛампочкаНеиспрБП5 ? ControlElementImages.lampType1OnRed : null;
            DAB_5ЛампочкаНеиспрБП4.BackgroundImage = DAB_5Parameters.DAB_5ЛампочкаНеиспрБП4 ? ControlElementImages.lampType1OnRed : null;
            DAB_5ЛампочкаНеиспрБП3.BackgroundImage = DAB_5Parameters.DAB_5ЛампочкаНеиспрБП3 ? ControlElementImages.lampType1OnRed : null;
            DAB_5ЛампочкаНеиспрБП2.BackgroundImage = DAB_5Parameters.DAB_5ЛампочкаНеиспрБП2 ? ControlElementImages.lampType1OnRed : null;
            DAB_5ЛампочкаНеиспрБП1.BackgroundImage = DAB_5Parameters.DAB_5ЛампочкаНеиспрБП1 ? ControlElementImages.lampType1OnRed : null;
        
            DAB_5ЛампочкаРежимДист.BackgroundImage = DAB_5Parameters.DAB_5ЛампочкаРежимДист ? ControlElementImages.lampType1OnRed : null;
            DAB_5ЛампочкаРежимАвтом.BackgroundImage = DAB_5Parameters.DAB_5ЛампочкаРежимАвтом ? ControlElementImages.lampType1OnRed : null;
            DAB_5ЛампочкаРежимРучн.BackgroundImage = DAB_5Parameters.DAB_5ЛампочкаРежимРучн ? ControlElementImages.lampType1OnRed : null;
            DAB_5ЛампочкаРежимМестн.BackgroundImage = DAB_5Parameters.DAB_5ЛампочкаРежимМестн ? ControlElementImages.lampType1OnRed : null;

            DAB_5ЛампочкаОбход.BackgroundImage = DAB_5Parameters.DAB_5ЛампочкаОбход ? ControlElementImages.lampType10OnGreen: null;
            DAB_5ЛампочкаПитание.BackgroundImage = DAB_5Parameters.DAB_5ЛампочкаПитание ? ControlElementImages.lampType10OnGreen : null;
        }
    }
}