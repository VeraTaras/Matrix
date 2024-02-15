using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP._2
{
    public partial class Form1 : Form
    {
        double[,] A;
        double[,] B;
        double[,] C;
        double k;
        double detA;
        enum Matrices { None, MatrixA, MatrixB, MatrixC };
        Matrices matrix = Matrices.None;

        public Form1()
        {
            InitializeComponent();
            dataGridView1.RowCount = 50;
            dataGridView1.ColumnCount = 20;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (matrix)
            {
                case Matrices.MatrixA:
                    Matrix.showMatrix(A, dataGridView1);
                    break;
                case Matrices.MatrixB:
                    Matrix.showMatrix(B, dataGridView1);
                    break;
                case Matrices.MatrixC:
                    Matrix.showMatrix(C, dataGridView1);
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (matrix)
            {
                case Matrices.MatrixA:
                    A = Matrix.readMatrix(dataGridView1);
                    ChangeCellColor(dataGridView1.SelectedCells, Color.Khaki);
                    break;
                case Matrices.MatrixB:
                    B = Matrix.readMatrix(dataGridView1);
                    ChangeCellColor(dataGridView1.SelectedCells, Color.Khaki);
                    break;
            }
        }

        private void comboBoxChooseMatrix_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Item = comboBoxChooseMatrix.SelectedItem.ToString();
            switch (Item)
            {
                case "MatrixA-input":
                    matrix = Matrices.MatrixA;
                    break;
                case "MatrixB-input":
                    matrix = Matrices.MatrixB;
                    break;
                case "MatrixC-output":
                    matrix = Matrices.MatrixC;
                    break;
                case "None":
                    matrix = Matrices.None;
                    break;
            }
        }

        private void comboBoxOperating_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Item = comboBoxOperating.SelectedItem.ToString();
            switch (Item)
            {
                case "A+B":
                    C = Matrix.matrixAddition(A, B);
                    break;
                case "A-B":
                    C = Matrix.matrixSubstration(A, B);
                    break;
                case "k*A":
                    C = Matrix.matrixMultiplicationByScalar(k, A);
                    break;
                case "A*B":
                    C = Matrix.matrixMultiplication(A, B);
                    break;
                case "detA":
                    detA = Matrix.determinant(A);
                    break;
            }
        }


        private void buttonK_Click(object sender, EventArgs e)
        {
            k = Convert.ToDouble(dataGridView1.CurrentCell.Value.ToString());
            ChangeCellColor(dataGridView1.SelectedCells, Color.Khaki);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectedCells[0].Value = detA;
            ChangeCellColor(dataGridView1.SelectedCells, Color.GreenYellow);
        }

        private void ChangeCellColor(DataGridViewSelectedCellCollection selectedCells, Color color)
        {
            foreach (DataGridViewCell cell in selectedCells)
            {
                cell.Style.BackColor = color;
            }
        }

    }
}