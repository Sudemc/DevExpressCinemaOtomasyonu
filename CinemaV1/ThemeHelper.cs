using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;

namespace CinemaV1
{
    /// <summary>
    /// SDMCinema - Modern Soft Dark Mode Tema Sınıfı
    /// Netflix/Spotify tarzı göz yormayan, düşük kontrastlı profesyonel arayüz
    /// </summary>
    public static class ThemeHelper
    {
        // ═══════════════════════════════════════════════════════════════
        // SDMCinema RENK PALETİ - SOFT DARK MODE (Düşük Kontrast)
        // ═══════════════════════════════════════════════════════════════
        
        // Ana Arka Plan Renkleri (Göz yormayan antrasit tonları - TAM SİYAH DEĞİL)
        public static readonly Color RichBlack = Color.FromArgb(24, 24, 24);             // #181818 - Form arka plan (Koyu Antrasit)
        public static readonly Color Charcoal = Color.FromArgb(32, 32, 32);              // #202020 - Alternatif form arka plan
        public static readonly Color Graphite = Color.FromArgb(45, 45, 45);              // #2D2D2D - Panel/Kart arka plan
        public static readonly Color SlateGray = Color.FromArgb(58, 58, 58);             // #3A3A3A - Hover/Input arka plan
        public static readonly Color BorderGray = Color.FromArgb(70, 70, 70);            // #464646 - Border/Ayırıcı
        
        // Eski isimlendirmelerle uyumluluk
        public static readonly Color Black = RichBlack;
        public static readonly Color DarkGray = Charcoal;
        public static readonly Color MediumGray = Graphite;
        public static readonly Color LightGray = SlateGray;
        
        // Accent Renkleri - Amber/Mustard (Soft Gold yerine)
        public static readonly Color Gold = Color.FromArgb(255, 193, 7);                 // #FFC107 - Amber (Primary accent)
        public static readonly Color SoftGold = Color.FromArgb(255, 213, 79);            // #FFD54F - Light Amber (Hover)
        public static readonly Color WarmAmber = Color.FromArgb(225, 173, 1);            // #E1AD01 - Mustard (Secondary)
        public static readonly Color DarkGold = Color.FromArgb(255, 160, 0);             // #FFA000 - Dark Amber
        public static readonly Color LightGold = SoftGold;                                // Uyumluluk için
        
        // Metin Renkleri (Saf beyaz DEĞİL - Kırık beyaz)
        public static readonly Color PearlWhite = Color.FromArgb(224, 224, 224);         // #E0E0E0 - Ana metin (Kırık beyaz)
        public static readonly Color SilverGray = Color.FromArgb(160, 160, 160);         // #A0A0A0 - Label/İkincil metin
        public static readonly Color White = PearlWhite;                                  // Uyumluluk için
        public static readonly Color OffWhite = Color.FromArgb(200, 200, 200);           // #C8C8C8 - Placeholder text
        public static readonly Color TextGray = SilverGray;                               // Uyumluluk için
        
        // Aksiyon Renkleri
        public static readonly Color Danger = Color.FromArgb(229, 9, 20);                // #E50914 - Netflix Red (Sadece önemli butonlar)
        public static readonly Color DangerHover = Color.FromArgb(185, 7, 16);           // Hover state
        public static readonly Color Success = Color.FromArgb(46, 125, 50);              // #2E7D32 - Material Green
        public static readonly Color SuccessHover = Color.FromArgb(38, 105, 42);         // Hover state
        public static readonly Color Info = Color.FromArgb(33, 150, 243);                // #2196F3 - Material Blue

        // ═══════════════════════════════════════════════════════════════
        // DEVEXPRESS TEMA AYARLARI
        // ═══════════════════════════════════════════════════════════════
        
        /// <summary>
        /// DevExpress global tema ayarlarını uygular.
        /// Program.cs Main() metodunda Application.Run() öncesi çağrılmalı.
        /// </summary>
        public static void InitializeDevExpressTheme()
        {
            // The Bezier teması - Modern, dark mode
            UserLookAndFeel.Default.SetSkinStyle(SkinStyle.Bezier);
            WindowsFormsSettings.DefaultLookAndFeel.SetSkinStyle(SkinStyle.Bezier);
        }
        
        /// <summary>
        /// DevExpress kontrollerine özel renk paleti uygular.
        /// </summary>
        public static void ApplyDevExpressSkin(string skinName = "The Bezier")
        {
            UserLookAndFeel.Default.SkinName = skinName;
            UserLookAndFeel.Default.UseDefaultLookAndFeel = true;
        }

        // ═══════════════════════════════════════════════════════════════
        // FONT AYARLARI - SEGoe UI, İTALİK YOK, SADEce BOLD
        // ═══════════════════════════════════════════════════════════════
        
        // Sayfa Başlıkları (16-18pt, Semibold)
        public static readonly Font TitleFont = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
        public static readonly Font LargeTitleFont = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
        public static readonly Font SubtitleFont = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
        
        // Butonlar
        public static readonly Font ButtonFont = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        public static readonly Font SmallButtonFont = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        
        // İçerik ve Etiketler (9-10pt, Regular)
        public static readonly Font ContentFont = new Font("Segoe UI", 10F, FontStyle.Regular);
        public static readonly Font SmallFont = new Font("Segoe UI", 9F, FontStyle.Regular);
        public static readonly Font LabelFont = new Font("Segoe UI", 9F, FontStyle.Regular);
        
        // GroupBox
        public static readonly Font GroupFont = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);


        // ═══════════════════════════════════════════════════════════════
        // FORM TEMA UYGULAMA
        // ═══════════════════════════════════════════════════════════════

        /// <summary>
        /// Form ve tüm alt kontrollerine SDMCinema premium dark teması uygular.
        /// </summary>
        public static void ApplyTheme(Control container)
        {
            // Container arka planı Rich Black yap
            if (container is Form form)
            {
                form.BackColor = RichBlack;
            }
            
            ApplyThemeRecursive(container);
        }

        private static void ApplyThemeRecursive(Control container)
        {
            foreach (Control control in container.Controls)
            {
                ApplyControlTheme(control);
                
                if (control.HasChildren)
                {
                    ApplyThemeRecursive(control);
                }
            }
        }

        private static void ApplyControlTheme(Control control)
        {
            switch (control)
            {
                case System.Windows.Forms.Button btn:
                    StyleButton(btn);
                    break;
                case System.Windows.Forms.TextBox txt:
                    StyleTextBox(txt);
                    break;
                case System.Windows.Forms.ComboBox cmb:
                    StyleComboBox(cmb);
                    break;
                case System.Windows.Forms.Label lbl:
                    StyleLabel(lbl);
                    break;
                case System.Windows.Forms.GroupBox grp:
                    StyleGroupBox(grp);
                    break;
                case System.Windows.Forms.Panel pnl:
                    StylePanel(pnl);
                    break;
                case System.Windows.Forms.ListBox lst:
                    StyleListBox(lst);
                    break;
                case System.Windows.Forms.RadioButton rdo:
                    StyleRadioButton(rdo);
                    break;
                case System.Windows.Forms.CheckBox chk:
                    StyleCheckBox(chk);
                    break;
                case System.Windows.Forms.DateTimePicker dtp:
                    StyleDateTimePicker(dtp);
                    break;
                case System.Windows.Forms.NumericUpDown nud:
                    StyleNumericUpDown(nud);
                    break;
            }
        }

        // ═══════════════════════════════════════════════════════════════
        // BUTON STİLLEME - FLAT MODERN TASARIM
        // ═══════════════════════════════════════════════════════════════

        /// <summary>
        /// Varsayılan buton stili - Altın kenarlı, şeffaf görünüm
        /// </summary>
        public static void StyleButton(System.Windows.Forms.Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = Gold;
            btn.FlatAppearance.MouseOverBackColor = Graphite;
            btn.FlatAppearance.MouseDownBackColor = SlateGray;
            btn.Cursor = Cursors.Hand;
            btn.BackColor = Charcoal;
            btn.ForeColor = Gold;
            btn.Font = SmallButtonFont;
            
            // Hover efekti
            btn.MouseEnter -= Button_MouseEnter;
            btn.MouseLeave -= Button_MouseLeave;
            btn.MouseEnter += Button_MouseEnter;
            btn.MouseLeave += Button_MouseLeave;
        }

        private static void Button_MouseEnter(object? sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.Button btn)
            {
                // Tag'e göre farklı hover davranışları
                switch (btn.Tag?.ToString())
                {
                    case "danger":
                        btn.BackColor = DangerHover;
                        break;
                    case "success":
                        btn.BackColor = SuccessHover;
                        break;
                    case "primary":
                        btn.BackColor = SoftGold;
                        break;
                    default:
                        btn.BackColor = Gold;
                        btn.ForeColor = RichBlack;
                        break;
                }
            }
        }

        private static void Button_MouseLeave(object? sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.Button btn)
            {
                switch (btn.Tag?.ToString())
                {
                    case "danger":
                        btn.BackColor = Danger;
                        btn.ForeColor = PearlWhite;
                        break;
                    case "success":
                        btn.BackColor = Success;
                        btn.ForeColor = PearlWhite;
                        break;
                    case "primary":
                        btn.BackColor = Gold;
                        btn.ForeColor = RichBlack;
                        break;
                    default:
                        btn.BackColor = Charcoal;
                        btn.ForeColor = Gold;
                        break;
                }
            }
        }

        /// <summary>
        /// Exit/Close butonlarına muted red tema uygular.
        /// </summary>
        public static void StyleExitButton(System.Windows.Forms.Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = DangerHover;
            btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(150, 40, 55);
            btn.BackColor = Danger;
            btn.ForeColor = PearlWhite;
            btn.Cursor = Cursors.Hand;
            btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn.Tag = "danger";
        }

        /// <summary>
        /// Primary (ana aksiyon) butonlarına altın tema uygular.
        /// </summary>
        public static void StylePrimaryButton(System.Windows.Forms.Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = SoftGold;
            btn.FlatAppearance.MouseDownBackColor = WarmAmber;
            btn.BackColor = Gold;
            btn.ForeColor = RichBlack;
            btn.Cursor = Cursors.Hand;
            btn.Font = ButtonFont;
            btn.Tag = "primary";
        }

        /// <summary>
        /// Success (başarı/onay) butonlarına yeşil tema uygular.
        /// </summary>
        public static void StyleSuccessButton(System.Windows.Forms.Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = SuccessHover;
            btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 95, 50);
            btn.BackColor = Success;
            btn.ForeColor = PearlWhite;
            btn.Cursor = Cursors.Hand;
            btn.Font = ButtonFont;
            btn.Tag = "success";
        }

        /// <summary>
        /// Info/Detail butonlarına altın tema uygular.
        /// </summary>
        public static void StyleInfoButton(System.Windows.Forms.Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = SoftGold;
            btn.FlatAppearance.MouseDownBackColor = WarmAmber;
            btn.BackColor = Gold;
            btn.ForeColor = RichBlack;
            btn.Cursor = Cursors.Hand;
            btn.Font = SmallButtonFont;
            btn.Tag = "primary";
        }

        /// <summary>
        /// Secondary/Ghost buton stili - kenarlıklı, şeffaf
        /// </summary>
        public static void StyleSecondaryButton(System.Windows.Forms.Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = SilverGray;
            btn.FlatAppearance.MouseOverBackColor = Graphite;
            btn.FlatAppearance.MouseDownBackColor = SlateGray;
            btn.BackColor = Color.Transparent;
            btn.ForeColor = PearlWhite;
            btn.Cursor = Cursors.Hand;
            btn.Font = SmallButtonFont;
            btn.Tag = "secondary";
        }

        // ═══════════════════════════════════════════════════════════════
        // INPUT STİLLEME - MODERN FLAT TASARIM
        // ═══════════════════════════════════════════════════════════════

        /// <summary>
        /// TextBox'a premium dark tema uygular.
        /// </summary>
        public static void StyleTextBox(System.Windows.Forms.TextBox txt)
        {
            txt.BackColor = Graphite;
            txt.ForeColor = PearlWhite;
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.Font = ContentFont;
            
            txt.Enter -= TextBox_Enter;
            txt.Leave -= TextBox_Leave;
            txt.Enter += TextBox_Enter;
            txt.Leave += TextBox_Leave;
        }

        private static void TextBox_Enter(object? sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.TextBox txt)
            {
                txt.BackColor = SlateGray;
            }
        }

        private static void TextBox_Leave(object? sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.TextBox txt)
            {
                txt.BackColor = Graphite;
            }
        }

        /// <summary>
        /// ComboBox'a premium dark tema uygular.
        /// </summary>
        public static void StyleComboBox(System.Windows.Forms.ComboBox cmb)
        {
            cmb.BackColor = Graphite;
            cmb.ForeColor = PearlWhite;
            cmb.FlatStyle = FlatStyle.Flat;
            cmb.Font = ContentFont;
        }

        /// <summary>
        /// DateTimePicker'a tema uygular.
        /// </summary>
        public static void StyleDateTimePicker(System.Windows.Forms.DateTimePicker dtp)
        {
            dtp.CalendarMonthBackground = Charcoal;
            dtp.CalendarForeColor = PearlWhite;
            dtp.CalendarTitleForeColor = Gold;
            dtp.CalendarTitleBackColor = RichBlack;
            dtp.Font = ContentFont;
        }

        /// <summary>
        /// NumericUpDown'a tema uygular.
        /// </summary>
        public static void StyleNumericUpDown(System.Windows.Forms.NumericUpDown nud)
        {
            nud.BackColor = Graphite;
            nud.ForeColor = PearlWhite;
            nud.Font = ContentFont;
        }

        // ═══════════════════════════════════════════════════════════════
        // LABEL STİLLEME
        // ═══════════════════════════════════════════════════════════════

        /// <summary>
        /// Label'a tema uygular - İkincil etiket rengi (#A0A0A0 soluk gri)
        /// </summary>
        public static void StyleLabel(System.Windows.Forms.Label lbl)
        {
            // Eğer zaten özel renk varsa veya Gold ise dokunma
            if (lbl.ForeColor == Gold || lbl.ForeColor == SoftGold || lbl.Tag?.ToString() == "title")
            {
                return;
            }
            
            // Varsayılan label'ler soluk gri olsun
            if (lbl.ForeColor == System.Drawing.SystemColors.ControlText || 
                lbl.ForeColor == Color.FromArgb(84, 110, 128) ||
                lbl.ForeColor == Color.Black)
            {
                lbl.ForeColor = SilverGray; // #A0A0A0 - Soluk gri
            }
            
            if (lbl.BackColor == System.Drawing.SystemColors.Control)
            {
                lbl.BackColor = Color.Transparent;
            }
            
            // Font düzeltme - Segoe UI, italik yok
            if (lbl.Font.Style == FontStyle.Italic || lbl.Font.Name != "Segoe UI")
            {
                lbl.Font = LabelFont; // 9pt Segoe UI Regular
            }
        }

        /// <summary>
        /// Başlık Label'larına altın renk uygular.
        /// </summary>
        public static void StyleTitleLabel(System.Windows.Forms.Label lbl)
        {
            lbl.ForeColor = Gold;
            lbl.BackColor = Color.Transparent;
            lbl.Font = TitleFont;
        }

        /// <summary>
        /// Alt başlık Label'larına stil uygular.
        /// </summary>
        public static void StyleSubtitleLabel(System.Windows.Forms.Label lbl)
        {
            lbl.ForeColor = SoftGold;
            lbl.BackColor = Color.Transparent;
            lbl.Font = SubtitleFont;
        }

        /// <summary>
        /// İkincil/açıklama metinleri için gri stil.
        /// </summary>
        public static void StyleSecondaryLabel(System.Windows.Forms.Label lbl)
        {
            lbl.ForeColor = SilverGray;
            lbl.BackColor = Color.Transparent;
            lbl.Font = ContentFont;
        }

        // ═══════════════════════════════════════════════════════════════
        // PANEL & GROUPBOX STİLLEME
        // ═══════════════════════════════════════════════════════════════

        /// <summary>
        /// GroupBox'a premium dark tema uygular.
        /// </summary>
        public static void StyleGroupBox(System.Windows.Forms.GroupBox grp)
        {
            grp.BackColor = Charcoal;
            grp.ForeColor = Gold;
            grp.Font = GroupFont;
        }

        /// <summary>
        /// Panel'e tema uygular.
        /// </summary>
        public static void StylePanel(System.Windows.Forms.Panel pnl)
        {
            if (pnl is FlowLayoutPanel) return;
            
            // Header panel'ler için Graphite (#2D2D2D)
            if (pnl.Dock == DockStyle.Top)
            {
                pnl.BackColor = Graphite;
            }
            // Sidebar panel'ler için Graphite
            else if (pnl.Dock == DockStyle.Left)
            {
                pnl.BackColor = Graphite;
            }
        }

        /// <summary>
        /// Header Panel'e özel stil uygular (form başlık çubuğu).
        /// Amber accent rengi kullanır.
        /// </summary>
        public static void StyleHeaderPanel(System.Windows.Forms.Panel pnl)
        {
            pnl.BackColor = Graphite; // #2D2D2D - Panel arka plan
        }

        /// <summary>
        /// Sidebar Panel'e özel stil uygular.
        /// </summary>
        public static void StyleSidebarPanel(System.Windows.Forms.Panel pnl)
        {
            pnl.BackColor = Charcoal;
        }

        /// <summary>
        /// Kart stili panel (hafif yükseltilmiş görünüm).
        /// </summary>
        public static void StyleCardPanel(System.Windows.Forms.Panel pnl)
        {
            pnl.BackColor = Charcoal;
            pnl.Padding = new Padding(12);
        }

        // ═══════════════════════════════════════════════════════════════
        // LİSTE & SEÇİM KONTROL STİLLEME
        // ═══════════════════════════════════════════════════════════════

        /// <summary>
        /// ListBox'a premium dark tema uygular.
        /// </summary>
        public static void StyleListBox(System.Windows.Forms.ListBox lst)
        {
            lst.BackColor = Graphite;
            lst.ForeColor = PearlWhite;
            lst.BorderStyle = BorderStyle.FixedSingle;
            lst.Font = ContentFont;
        }

        /// <summary>
        /// RadioButton'a altın tema uygular.
        /// </summary>
        public static void StyleRadioButton(System.Windows.Forms.RadioButton rdo)
        {
            rdo.ForeColor = PearlWhite;
            rdo.BackColor = Color.Transparent;
            rdo.FlatStyle = FlatStyle.Flat;
            rdo.Font = ContentFont;
        }

        /// <summary>
        /// CheckBox'a tema uygular.
        /// </summary>
        public static void StyleCheckBox(System.Windows.Forms.CheckBox chk)
        {
            chk.ForeColor = PearlWhite;
            chk.BackColor = Color.Transparent;
            chk.FlatStyle = FlatStyle.Flat;
            chk.Font = ContentFont;
        }

        /// <summary>
        /// FlowLayoutPanel'e tema uygular.
        /// </summary>
        public static void StyleFlowPanel(FlowLayoutPanel flp)
        {
            flp.BackColor = RichBlack;
        }

        // ═══════════════════════════════════════════════════════════════
        // USERCONTROL TEMA
        // ═══════════════════════════════════════════════════════════════

        /// <summary>
        /// UserControl'e premium dark tema uygular.
        /// </summary>
        public static void ApplyUserControlTheme(UserControl uc)
        {
            uc.BackColor = Charcoal;
            ApplyThemeRecursive(uc);
        }

        // ═══════════════════════════════════════════════════════════════
        // DEVEXPRESS KONTROL STİLLEME
        // ═══════════════════════════════════════════════════════════════

        /// <summary>
        /// DevExpress SimpleButton'a tema uygular.
        /// </summary>
        public static void StyleSimpleButton(SimpleButton btn)
        {
            btn.Appearance.BackColor = Gold;
            btn.Appearance.ForeColor = RichBlack;
            btn.Appearance.Font = ButtonFont;
            btn.Appearance.Options.UseBackColor = true;
            btn.Appearance.Options.UseForeColor = true;
            btn.Appearance.Options.UseFont = true;
            
            // Hover için
            btn.AppearanceHovered.BackColor = SoftGold;
            btn.AppearanceHovered.ForeColor = RichBlack;
            btn.AppearanceHovered.Options.UseBackColor = true;
            btn.AppearanceHovered.Options.UseForeColor = true;
            
            // Pressed için
            btn.AppearancePressed.BackColor = WarmAmber;
            btn.AppearancePressed.ForeColor = RichBlack;
            btn.AppearancePressed.Options.UseBackColor = true;
            btn.AppearancePressed.Options.UseForeColor = true;
        }

        /// <summary>
        /// DevExpress TextEdit'e tema uygular.
        /// </summary>
        public static void StyleTextEdit(TextEdit txt)
        {
            txt.Properties.Appearance.BackColor = Graphite;
            txt.Properties.Appearance.ForeColor = PearlWhite;
            txt.Properties.Appearance.Font = ContentFont;
            txt.Properties.Appearance.Options.UseBackColor = true;
            txt.Properties.Appearance.Options.UseForeColor = true;
            txt.Properties.Appearance.Options.UseFont = true;
            
            // Focus için
            txt.Properties.AppearanceFocused.BackColor = SlateGray;
            txt.Properties.AppearanceFocused.Options.UseBackColor = true;
        }

        /// <summary>
        /// DevExpress LabelControl'e tema uygular.
        /// </summary>
        public static void StyleLabelControl(LabelControl lbl)
        {
            lbl.Appearance.ForeColor = PearlWhite;
            lbl.Appearance.Font = ContentFont;
            lbl.Appearance.Options.UseForeColor = true;
            lbl.Appearance.Options.UseFont = true;
        }

        /// <summary>
        /// DevExpress PanelControl'e tema uygular.
        /// </summary>
        public static void StylePanelControl(PanelControl pnl)
        {
            pnl.Appearance.BackColor = Charcoal;
            pnl.Appearance.Options.UseBackColor = true;
        }
    }
}
