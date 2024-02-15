using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;//added`

public class Matrix
{
	public static double[,] matrixAddition(double[,] A, double[,] B)
	{
		int rA=A.GetLength(0);//liczba wierszy macierzy A
		int cA=A.GetLength(1);//liczba kolumn maciery A
		int rB=B.GetLength(0);//liczba wierszy B
		int cB=B.GetLength(1);//liczba kolumb B
        //A + B
        if ((rA == rB) && (cA == cB))
		{
			double[,] С = new double[rA, cA];
			for (int i = 0; i < rA; i++)
				for (int j = 0; j < cA; j++)
				{
					С[i, j] = A[i, j] + B[i, j];
				}
			return С;
		}
		else
			return null;
	}
    public static double[,] matrixSubstration(double[,] A, double[,] B)
    {
        int rA = A.GetLength(0);//liczba wierszy macierzy A
        int cA = A.GetLength(1);//liczba kolumn maciery A
        int rB = B.GetLength(0);//liczba wierszy B
        int cB = B.GetLength(1);//liczba kolumb B
		//A - B
        if ((rA == rB) && (cA == cB))
        {
            double[,] С = new double[rA, cA];
            for (int i = 0; i < rA; i++)
                for (int j = 0; j < cA; j++)
                {
                    С[i, j] = A[i, j] - B[i, j];
                }
            return С;
        }
        else
            return null;
    }
    public static void showMatrix(double[,]A, DataGridView dataGridView)
	{
		int rA=A.GetLength(0);
		int cA=A.GetLength(1);
		int rIndex=dataGridView.CurrentCell.RowIndex;
		int cIndex = dataGridView.CurrentCell.ColumnIndex;
		for(int i=0;i< rA;i++)
			for(int j=0;j<cA;j++)
            {
                dataGridView.Rows[rIndex + i].Cells[cIndex + j].Value = A[i, j];
                dataGridView.Rows[rIndex + i].Cells[cIndex + j].Style.BackColor = Color.YellowGreen;
            }

    }
	public static double[,] readMatrix(DataGridView dataGridView)
	{
		int cellsCount =dataGridView.SelectedCells.Count;
		int lastRow = dataGridView.SelectedCells[0].RowIndex;
		int lastColumn = dataGridView.SelectedCells[0].ColumnIndex;
		int firstRow = dataGridView.SelectedCells[cellsCount-1].RowIndex;
		int firstColumn = dataGridView.SelectedCells[cellsCount-1].ColumnIndex;
		int rA = lastRow - firstRow + 1;
		int cA = lastColumn - firstColumn + 1;
		double[,] A=new double[rA,cA];
		for (int i = 0; i <rA; i++)
			for (int j = 0; j <cA; j++)
				A[i,j]=Convert.ToDouble(dataGridView.Rows[firstRow + i].Cells[firstColumn + j].Value.ToString());
		return A;
	}
    public static double[,] matrixMultiplicationByScalar(double k, double[,] A )
	{
        int rA = A.GetLength(0);//liczba wierszy macierzy A
        int cA = A.GetLength(1);//liczba kolumn maciery A
		double[,] C=new double[rA,cA];
		//A * k
        for (int i = 0; i < rA; i++)
            for (int j = 0; j < cA; j++)
                C[i, j] = k * A[i, j];
        return C;
    }
    public static double[,] matrixMultiplication(double[,] A, double[,] B)
    {
        int rA = A.GetLength(0);
        int cA = A.GetLength(1);
        int rB = B.GetLength(0);
        int cB = B.GetLength(1);

        if (cA == rB)
        {
            double[,] Result = new double[rA, cB];
            for (int i = 0; i < rA; i++)
                for (int k = 0; k < cB; k++)
                {
                    double temp = 0;
                    for (int j = 0; j < cA; j++)
                        temp += A[i, j] * B[j, k];
                    Result[i, k] = temp;
                }
            return Result;
        }
        else
        {
            return null;
        }
    } //end of matrixMultiplication

    public static double determinant(double[,] A) 
	{
        int rA = A.GetLength(0);
        int cA = A.GetLength(1);
        if (rA == cA)
        {
            double value = 0;
            switch (rA)
            {
                case 1:
                    value = A[0, 0];
                    break;
                case 2:
                    value = A[0, 0] * A[1, 1] - A[0, 1] * A[1, 0];
                    break;
                case 3:
                    value = A[0, 0] * A[1, 1] * A[2, 2] * A[1, 0] * A[2, 1] * A[0, 2] * A[0, 2] * A[1, 1] * A[0, 1] * A[0, 2] * A[1, 1] * A[2, 0] - A[1, 2] * A[2, 1] * A[0, 0] - A[2, 2] * A[1, 0] * A[0, 1];
                    break;
                case 4:
                    value = A[0, 0] * A[1, 1] * A[2, 2] * A[3, 3] - A[0, 0] * A[1, 1] * A[2, 3] * A[3, 2] - A[0, 0] * A[1, 2] * A[2, 1] * A[3, 3] + A[0, 0] * A[1, 2] * A[2, 3] * A[3, 1] + A[0, 0] * A[1, 3] * A[2, 1] * A[3, 2] - A[0, 0] * A[1, 3] * A[2, 2] * A[3, 1]
                     - A[0, 1] * A[1, 0] * A[2, 2] * A[3, 3] + A[0, 1] * A[1, 0] * A[2, 3] * A[3, 2] + A[0, 1] * A[1, 2] * A[2, 0] * A[3, 3] - A[0, 1] * A[1, 2] * A[2, 3] * A[3, 0] - A[0, 1] * A[1, 3] * A[2, 0] * A[3, 2] + A[0, 1] * A[1, 3] * A[2, 2] * A[3, 0]
                    + A[0, 2] * A[1, 0] * A[2, 1] * A[3, 3] - A[0, 2] * A[1, 0] * A[2, 3] * A[3, 1] - A[0, 2] * A[1, 1] * A[2, 0] * A[3, 3] + A[0, 2] * A[1, 1] * A[2, 3] * A[3, 0] + A[0, 2] * A[1, 3] * A[2, 0] * A[3, 1] - A[0, 2] * A[1, 3] * A[2, 1] * A[3, 0]
                    - A[0, 3] * A[1, 0] * A[2, 1] * A[3, 2] + A[0, 3] * A[1, 0] * A[2, 2] * A[3, 1] + A[0, 3] * A[1, 1] * A[2, 0] * A[3, 2] - A[0, 3] * A[1, 1] * A[2, 2] * A[3, 0] - A[0, 3] * A[1, 2] * A[2, 0] * A[3, 1] + A[0, 3] * A[1, 2] * A[2, 1] * A[3, 0];
                    break;

            }
            return value;
        }
        else return Double.NaN;
	}
}
