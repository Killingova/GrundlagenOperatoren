namespace GrundlagenOperatorenRechnen
{
    public partial class CmdFenter : Form
    {
        public CmdFenter()
        {
            InitializeComponent();
        }

        // Behandelt das Klicken auf CmdAnzeige1.
        private void CmdAnzeige1_Click(object sender, EventArgs e)
        {
            int x = 5; // Initialisiert x mit dem Wert 5.
            x++; // Post-Inkrement: Erhöht x um 1, x ist jetzt 6. Wert von x wird zuerst verwendet, dann erhöht.
            ++x; // Pre-Inkrement: Erhöht x um 1, bevor es verwendet wird, x ist jetzt 7.
            x = x + 1; // Direkte Addition und Zuweisung: Addiert 1 zu x, x ist jetzt 8.
            LblAnzeige.Text = $"Ergebnis: {x}"; // Zeigt das Ergebnis (8) im Label an.
        }

        // Behandelt das Klicken auf CmdAnzeige2.
        private void CmdAnzeige2_Click(object sender, EventArgs e)
        {
            int x = 5; // Initialisiert x mit dem Wert 5.
            // Nutzt den Post-Inkrement-Operator. Der aktuelle Wert von x wird zuerst für die Anzeige verwendet, dann wird x erhöht.
            LblAnzeige.Text = $"Ergebnis: {x++}";
            // Da das Inkrement nach der Wertverwendung stattfindet, zeigt das Label "5" an, obwohl x danach auf 6 gesetzt wird.
        }


        // Behandelt das Klicken auf CmdAnzeige3.
        private void CmdAnzeige3_Click(object sender, EventArgs e)
        {
            int x = 5; // Initialisiert x mit dem Wert 5.
            // Nutzt den Pre-Inkrement-Operator. x wird vor der Verwendung für die Anzeige erhöht.
            LblAnzeige.Text = $"Ergebnis: {++x}";
            // Da x vor der Wertverwendung inkrementiert wird, zeigt das Label "6" an.
        }

        private void CmdAnzeige4_Click(object sender, EventArgs e)
        {
            double x = 3; // Initialisiert x als double mit dem Wert 3
            // Führt mehrere Operationen aus. Multiplikation wird vor Addition durchgeführt gemäß Punkt-vor-Strich.
            x = x * -2.5 + 4 * 2; // x wird zuerst mit -2.5 multipliziert, dann wird das Ergebnis der Multiplikation 4*2 addiert.
            LblAnzeige.Text = $"Ergebnis: {x}";
            // Zeigt das berechnete Ergebnis im Label an.
        }

        private void CmdAnzeige5_Click(object sender, EventArgs e)
        {
            double x = 3;
            // Demonstriert Klammern, die die Ausführungsreihenfolge ändern. Zuerst wird -2.5+4 berechnet, dann das Ergebnis mit x multipliziert und mit 2 multipliziert.
            x = x * (-2.5 + 4) * 2;
            LblAnzeige.Text = $"Ergebnis: {x}";
        }
        private void CmdAnzeige6_Click(object sender, EventArgs e)
        {

        }

        private void CmdAnzeige6_Click_1(object sender, EventArgs e)
        {

        }

        private void CmdAnzeige7_Click(object sender, EventArgs e)
        {
            // Vergleicht zwei Strings mit dem Ungleichheitsoperator, um zu prüfen, ob sie unterschiedlich sind.
            bool ergebnis = "Maier" != "Mayer"; // Prüft, ob "Maier" nicht gleich "Mayer" ist. Ergebnis ist true, da sie unterschiedlich sind.
            LblAnzeige.Text = $"Ergebnis: {ergebnis}"; // Zeigt das Ergebnis (true) im Label an.
        }

        private void CmdAnzeige6_Click_2(object sender, EventArgs e)
        {
            // Prüft, ob 12 - 3 größer oder gleich 4 * 2.5 ist.
            bool ergebnis = 12 - 3 >= 4 * 2.5; // Führt die Berechnung und den Vergleich aus.
            LblAnzeige.Text = $"Ergebnis: {ergebnis}"; // Zeigt das Ergebnis des Vergleichs im Label an.
        }

        private void CmdAnzeige8_Click(object sender, EventArgs e)
        {
            // 1. Ausdruck: 4 > 3 && -4 > -3
            // Dieser Ausdruck prüft zwei Bedingungen: ob 4 größer als 3 ist UND ob -4 größer als -3 ist.
            // Der erste Teil der Bedingung (4 > 3) ist wahr (true), aber der zweite Teil (-4 > -3) ist falsch (false),
            // da -4 nicht größer als -3 ist. Da der logische UND-Operator (&&) verwendet wird, muss beides wahr sein,
            // damit das gesamte Ergebnis wahr ist. In diesem Fall ist das Gesamtergebnis falsch (false),
            // da eine der Bedingungen falsch ist.
            bool ausdruck1 = 4 > 3 && -4 > -3; // Das Ergebnis wird false sein.
            LblAnzeige.Text = $"Ergebnis:{ausdruck1}";
        }

        private void CmdAnzeige9_Click(object sender, EventArgs e)
        {
            // 2. Ausdruck: 4 > 3 || -4 > -3
            // Dieser Ausdruck prüft, ob mindestens eine der beiden Bedingungen wahr ist: ob 4 größer als 3 ist ODER ob -4 größer als -3 ist.
            // Wie vorher, ist der erste Teil (4 > 3) wahr, und der zweite Teil (-4 > -3) ist falsch.
            // Da hier der logische ODER-Operator (||) verwendet wird, ist das Gesamtergebnis wahr (true),
            // weil mindestens eine der Bedingungen (4 > 3) wahr ist.
            bool ausdruck2 = 4 > 3 || -4 > -3; // Das Ergebnis wird true sein.
            LblAnzeige.Text = $"Ergebnis:{ausdruck2}";
        }

        private void CmdAnzeige10_Click(object sender, EventArgs e)
        {
            // Bedingung 1: a=5, b=10, a>0 && b!=10
            int a = 5, b = 10;
            bool bedingung1 = a > 0 && b != 10; // False, da b tatsächlich 10 ist
            LblAnzeige.Text = $"Bedingung a>0 && b!=10 Ergebnis: {bedingung1}";
        }

        private void CmdAnzeige11_Click(object sender, EventArgs e)
        {
            // Bedingung 2: a=5, b=10, a>0 || b!=10
            int a = 5, b = 10;
            bool bedingung2 = a > 0 || b != 10; // True, da a größer als 0 ist
            LblAnzeige.Text = $"Bedingung a>0 || b!=10 Ergebnis: {bedingung2}";
        }

        private void CmdAnzeige12_Click(object sender, EventArgs e)
        {
            // Bedingung 3: z=10, w=100, z!=0 || z>w || w-z==90
            int z = 10, w = 100;
            bool bedingung3 = z != 0 || z > w || w - z == 90; // True, da w-z gleich 90 ist
            LblAnzeige.Text = $"Bedingung z!=0 || z>w || w-z==90 Ergebnis: {bedingung3}";
        }

        private void CmdAnzeige13_Click(object sender, EventArgs e)
        {
            // Bedingung 4: z=10, w=100, z==11 && z>w || w-z==90
            int z = 10, w = 100;
            bool bedingung4 = (z == 11 && z > w) || w - z == 90; // True, da w-z gleich 90 ist
            LblAnzeige.Text = $"Bedingung z==11 && z>w || w-z==90 Ergebnis: {bedingung4}";
        }

        private void CmdAnzeige14_Click(object sender, EventArgs e)
        {
            // Bedingung 5: x=1.0, y=5.7, x>=.9 && y<=5.8
            double x = 1.0, y = 5.7;
            bool bedingung5 = x >= 0.9 && y <= 5.8; // True, da beide Bedingungen erfüllt sind
            LblAnzeige.Text = $"Bedingung x>=.9 && y<=5.8 Ergebnis: {bedingung5}";
        }

        private void CmdAnzeige15_Click(object sender, EventArgs e)
        {
            // Bedingung 6: x=1.0, y=5.7, x>=.9 && !(y<=5.8)
            double x = 1.0, y = 5.7;
            bool bedingung6 = x >= 0.9 && !(y <= 5.8); // False, da die Negation der zweiten Bedingung falsch ist
            LblAnzeige.Text = $"Bedingung x>=.9 && !(y<=5.8) Ergebnis: {bedingung6}";
        }

        private void CmdAnzeige16_Click(object sender, EventArgs e)
        {
            // Bedingung 7: n1=1, n2=17, n1>0 && n2>0 || n1>n2 && n2!=17
            int n1 = 1, n2 = 17;
            bool bedingung7 = n1 > 0 && n2 > 0 || n1 > n2 && n2 != 17; // True, da n1 und n2 beide größer als 0 sind
            LblAnzeige.Text = $"Bedingung n1>0 && n2>0 || n1>n2 && n2!=17 Ergebnis: {bedingung7}";
        }

        private void CmdAnzeige17_Click(object sender, EventArgs e)
        {
            // Bedingung 8: n1=1, n2=17, n1>0 && (n2>0 || n1>n2) && n2!=17
            int n1 = 1, n2 = 17;
            bool bedingung8 = n1 > 0 && (n2 > 0 || n1 > n2) && n2 != 17; // False, da der letzte Teil der Bedingung falsch ist
            LblAnzeige.Text = $"Bedingung n1>0 && (n2>0 || n1>n2) && n2!=17 Ergebnis: {bedingung8}";
        }

    }
}