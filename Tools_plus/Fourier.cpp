#include <bits/stdc++.h>
using namespace std;


using type = double; // Kieu du lieu cac phan tu cua ma tran

const double PI = 3.14159265359;
const double e = 0.000001;

struct Complex {
	double real, imag;
	
	Complex() = default;
	Complex(double real, double imag) : real(real), imag(imag) {}
	 // In ra so phuc
    friend ostream & operator << (ostream &out, const Complex &d) {
    	double t1 = d.real, t2 = d.imag;
    	if (abs(t1) <= e) t1 = 0;
    	if (abs(t2) <= e) t2 = 0;
     	out << setprecision(5) << t1;
		if (t2 >= 0) out << "+";
 		out << setprecision(5) <<t2<<"i";
        return out;
    }
    Complex operator + (const Complex &b) {
    	Complex a = *this;
    	Complex c;
    	c.real = a.real + b.real;
    	c.imag = a.imag + b.imag;
    	return c;
	}
	Complex operator - (const Complex &b) {
    	Complex a = *this;
    	Complex c;
    	c.real = a.real - b.real;
    	c.imag = a.imag - b.imag;
    	return c;
	}
	Complex operator * (const Complex &b) {
    	Complex a = *this;
    	Complex c;
    	c.real = a.real*b.real - a.imag*b.imag;
    	c.imag = a.real*b.imag + a.imag*b.real;
    	return c;
	}
	Complex operator / (const Complex &b) {
    	Complex a = *this;
    	Complex c;
    	double x1 = a.real, y1 = a.imag, x2 = b.real, y2 = b.imag;
    	c.real = (x1*x2+y1*y2)/(x2*x2+y2*y2);
    	c.imag = (x2*y1-x1*y2)/(x2*x2+y2*y2);
    	return c;
	}
};



int M, N;
double b[10][10];
Complex FT[10][10], FN[10][10];

struct Matrix {
    vector <vector <type> > data;

    // so luong hang cua ma tran
    int row() const { return data.size(); } 

    // So luong cot cua ma tran
    int col() const { return data[0].size(); }

    auto & operator [] (int i) { return data[i]; }
    
    const auto & operator[] (int i) const { return data[i]; }

    Matrix() = default;
    
    Matrix(int r, int c): data(r, vector <type> (c)) { }

    Matrix(const vector <vector <type> > &d): data(d) {

        // Kiem tra các hàng có cùng size không và size có lon hon 0 hay không
        // Tuy nhiên không thuc su can thiet, ta có the bo các dòng /**/ di
        /**/ assert(d.size());
        /**/ int size = d[0].size();
        /**/ assert(size);
        /**/ for (auto x : d) assert(x.size() == size);
    }

    // In ra ma tran
    friend ostream & operator << (ostream &out, const Matrix &d) {
        for (auto x : d.data) {
            for (auto y : x) out << y << ' ';
            out << '\n';
        }
        return out;
    }

    // Ma tran don vi
    static Matrix identity(long long n) {
        Matrix a = Matrix(n, n);
        while (n--) a[n][n] = 1;
        return a;
    }

	// Ma tran chuyen vi
	Matrix transpose() {
		Matrix a = *this;
		Matrix b = Matrix(a.col(), a.row());
		// 1 2 3  --> 1 4
		// 4 5 6      2 5
		//            3 6
		for (int row = 0; row < a.col(); row ++ )
			for (int col = 0; col < a.row(); col ++)
				b[row][col] = a[col][row];
		return b;
	}
	

    // Nhân ma tran
    Matrix operator * (const Matrix &b) {
        Matrix a = *this;

        // Kiem tra dieu kien nhân ma tran
        assert(a.col() == b.row()); 

        Matrix c(a.row(), b.col());
        for (int i = 0; i < a.row(); ++i)
            for (int j = 0; j < b.col(); ++j)
                for (int k = 0; k < a.col(); ++k)
                    c[i][j] += a[i][k] * b[k][j];
        return c;
    }
	
	// Tinh dinh thuc cua ma tran
	type delta() {
		Matrix a = *this;
		type del;
		if (a.row() ==  a.col() && a.row() == 1) return a[0][0];
		if (a.row() == a.col() && a.row() == 2) {
			// ma tran 2x2
			del = a[0][0] * a[1][1] - a[1][0] * a[0][1];
		}
		else if ( a.row() == a.col() && a.row() == 3) {
			// xu ly ma tran 3x3
			del  =   a[0][0]*a[1][1]*a[2][2] + a[0][1]*a[1][2]*a[2][0] + a[1][0]*a[2][1]*a[0][2]
				   - a[0][2]*a[1][1]*a[2][0] - a[0][1]*a[1][0]*a[2][2] - a[1][2]*a[2][1]*a[0][0];
		}
		
		return del;
	}
	// tinh ma tran ADJ(i,j) ma tran con bo hang i, cot j
	Matrix getAdj(int i_, int j_) {
		Matrix a = *this;
		Matrix c = Matrix(a.row() - 1, a.col() - 1);
		int row = 0;
		int col = 0;
		for (int i = 0; i < a.row(); i ++)
			for (int j = 0; j < a.col(); j++) 
				// Neu la hang i, cot j se khong xet
				if (i != i_ && j != j_) {
						c[row][col++] = a[i][j];
						// Neu cot cuoi cung thi reset col, tang row				
						if (col == a.col() - 1) col = 0, row++;
				}	
		return c;  
	}
	// Tinh ma tran M voi M(i,j) = (-1) ^ (i+j) * delta(A(j,i)) \ su dung tinh A^-1
	Matrix adj() {
		Matrix a = *this;
		Matrix c = Matrix(a.row(), a.col());
		for (int i = 0; i < a.row(); i++)
			for (int j = 0; j < a.col(); j++) {
				int sign = ((i+j) % 2 == 0) ? 1 : -1;
				c[i][j] = sign * a.getAdj(j,i).delta();
			}
		return c;
	}
	
	// Ma tran nghich dao	
	Matrix inverse() {
		Matrix a = *this;
		Matrix b = Matrix(a.row(), a.col());
		assert(a.row() == 2 && a.col() == 2);
		type del = a.delta();
		Matrix adjoint = a.adj();
		for (int i = 0; i < a.row(); i++)
			for (int j = 0; j < a.col(); j++)
				b[i][j] = adjoint[i][j] / (1.0 * del);
		return b;
	}
    // Luy thua ma tran
    Matrix pow(long long exp) {

        // Kiem tra dieu kien luy thua ma tran (là ma tran vuông)
        assert(row() == col());  

        Matrix base = *this, ans = identity(row());
        for (; exp > 0; exp >>= 1, base = base * base)
            if (exp & 1) ans = ans * base;
        return ans;
    }
};

void FourierThuan(double b[10][10], int M, int N) {	
	for (int u = 0; u < M; u++)
		for (int v = 0; v <N; v ++)
			{
				FT[u][v] = Complex(0,0);
				for (int i = 0; i < M; i++)
					for (int j = 0; j < N; j++)
					 {
					 	double A = (1.0*N*u*i + 1.0*N*v*j) / (1.0*M*N);
					 	double w = -2.0*PI*A;
					 	Complex t1 = Complex(b[i][j],0);
					 	Complex t2 = Complex(cos(w), sin(w));
						FT[u][v] = FT[u][v] + (t1 * t2);
					 }
			}
	cout << "Fourier thuan la : \n";
	for (int u = 0; u < M; u++){
		for (int v = 0; v <N; v ++)
		 cout << FT[u][v] << "\t";
		 cout << endl;
	}
} 


void FourierNghich(Complex b[10][10], int M, int N) {		
	for (int u = 0; u < M; u++)
		for (int v = 0; v <N; v ++)
			{
				FN[u][v] = Complex(0,0);
				for (int i = 0; i < M; i++)
					for (int j = 0; j < N; j++)
					 {
					 	double A = (1.0*N*u*i + 1.0*N*v*j) / (1.0*M*N);
					 	double w = 2.0*PI*A;
					 	Complex t2 = Complex(cos(w), sin(w));
						FN[u][v] = FN[u][v] + (b[i][j] * t2);
					 }
				FN[u][v] = FN[u][v] / Complex(M*N, 0);
			}
	cout << "Fourier nghich la : \n";
	for (int u = 0; u < M; u++){
		for (int v = 0; v <N; v ++)
		 cout << FN[u][v] << "\t";
		 cout << endl;
	}
} 
int main(){
	cout << "Nhap M = "; cin >> M;
	cout << "Nhap N = "; cin >> N;
	for (int i = 0; i < M; i++) 
		for (int j = 0; j < N; j++) 
		 	cin >> b[i][j];
	FourierThuan(b, M, N);
	FourierNghich(FT, M, N);
}
