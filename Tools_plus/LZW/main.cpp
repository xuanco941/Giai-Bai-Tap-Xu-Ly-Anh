#include <bits/stdc++.h>
#define FOR(i,a,b) for (int i  = a; i < b; i++)
using namespace std;
unsigned int countSetBits(unsigned int n)
{
	if (n < 256) return 8;
	if (n < 512) return 9;
	if (n < 1024) return 10;
	if (n < 2048) return 11;
	if (n < 4096) return 12;
    unsigned int count = 0;
    while (n) {
        count += 1;
        n >>= 1;
    }
    return count;
}

vector<int> encoding(vector<string> s1)
{
	int k = 1;
	cout << "Encoding\n";
	unordered_map<string, int> table;
	for (int i = 0; i <= 255; i++) 
		for (int j = 0; j < s1.size(); j++)
			if (s1[j] == to_string(i)) {
				 table[s1[j]] = i;
				 break;
				}
	string p = "", c = "";
	p = s1[0];
	int code = 258;
	vector<int> output_code;
	cout << "STT\tDãy hiện tại\tPixel kế tiếp\tTừ\tMã\tĐầu ra\n";
	// STT - day hien tai - pixel ke tiep - tu - ma - dau ra
	cout << k++ <<"\tNULL\t" << p << endl;
	for (int i = 0; i < s1.size(); i++) {
		if (i != s1.size() - 1)
			c += s1[i + 1];
		if (table.find(p + c) != table.end()) {
			if (c != "")
				cout <<k++<<"\t"<<p << "\t" << c << "\t" << s1[i]+"-"+c << "\t" <<"đã có "<< table[p+c]<< endl;
			else 
				cout <<k++<<"\t"<<p << "\t#\t\t\t" <<table[p]<< endl;
			p = p + c;
		}
		else {
			cout <<k++<<"\t"<<p << "\t" << s1[i+1] << "\t" << p+"-"+c << "\t" << code <<"\t"<<table[p] << endl;
			output_code.push_back(table[p]);
			table[p + c] = code;
			code++;
			p = c;
		}
		c = "";
	}
//	cout << p << "\t" << table[p] << endl;
	output_code.push_back(table[p]);
	return output_code;
}

void decoding(vector<int> op)
{
	cout << "\nDecoding\n";
	unordered_map<int, string> table;
	for (int i = 0; i <= 255; i++) 
		for (int j = 0; j < op.size(); j++)
			if (op[j] == i) {
				 table[i] = to_string(i);
				 break;
				}
    int old = op[0], n;
    string s = table[old];
    string c = "";
    string output = "";
    c = s;
    cout << s << " ";
    int count = 258;
    for (int i = 0; i < op.size() - 1; i++) {
        n = op[i + 1];
        // Kiem tra so tiep theo co trong bang tu dien ko
        if (table.find(n) == table.end()) {
            s = table[old];
            s = s + c;
        }
        else {
            s = table[n];
        }
        cout << s << " ";
	    c = "";
	    c += s;
	    // Them ma count vao tu dien (cap so old + c)
	    table[count] = table[old] + c;
	    // tang ma tu dien len 1
	    count++;
	    // old = so tiep theo
	    old = n;
  
    }
}
int main()
{
	// Nhap ma tran
//	cout << "Nhap so bit  = "; cin >> bit;
	
	int m,n;
	cout << "Nhập m = "; cin >> m;
	cout << "Nhập n = "; cin >> n;
	vector<int> a;
	FOR(i,0,m) 
		FOR(j,0,n) {
			int x;
			cin >> x;
			a.push_back(x);
		}
	vector<string> s;
	for(auto x : a) s.push_back(to_string(x));
	vector<int> output_code = encoding(s);
	int bitNew = 0;
	cout << "Chuỗi sau nén: ";
	for (int i = 0; i < output_code.size(); i++) {
		cout << output_code[i] << " ";
		bitNew += countSetBits(output_code[i]);
	}
	cout << endl;
	// Dung luong anh truoc khi nen
	int bitBegin = 8 * m * n;
	cout << "Dung lượng ảnh trước khi nén = "<< bitBegin << endl;
	// Dung luong anh sau khi nen
	cout << "Dung lượng ảnh sau khi nén  = " << bitNew << endl;

	// Ti so nen
	double tsNen = 1.0*bitBegin / bitNew;
	cout <<"Tỉ số nén = Cr = "<<1.0*bitBegin<<"/"<<bitNew<<" = " << tsNen<<endl;
	// Do du thua du lieu
	double duThua = 1.0 - (1.0/tsNen);
	cout <<"Độ dư thừa = Dr = 1-1/Cr ="<<duThua << endl;
//	cout << endl;
//	decoding(output_code);
}

