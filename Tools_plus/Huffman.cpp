#include <bits/stdc++.h>
#define FOR(i,a,b) for (int i = a; i < b; i++)
using namespace std;
int m,n,bit, bitBegin;
int a[10][10];
int c[100];
int bitNew[100];

struct Node  {
	int data, freq;
	Node *left;
	Node *right;
	Node() {};
	Node(int data, int freq, Node *l = NULL, Node *r = NULL) {
		this->data = data;
		this->freq = freq;
		this->left = l;
		this->right = r;
	}
};

class cmp
{
public:
    bool operator() (Node* a, Node* b)
    {
        return a->freq > b->freq; 
    }
};
// tao cay huffman tree
priority_queue<Node*, vector<Node*>, cmp> pq;

void printCodes(Node* root, int array[], int len)
{
    // Danh dau 0 cho node trai
    if (root->left) {
        array[len] = 0;
        printCodes(root->left,array, len + 1);
    }
 
    // Danh dau 1 cho node phai
    if (root->right) {
        array[len] = 1;
        printCodes(root->right, array, len + 1);
    }
 
    // nut la thi in ra data + code
    if (root->left == NULL && root->right == NULL) {
        cout << root->data << " ";
        for (int i = 0; i < len; i++) {
            cout << array[i];
        }
        bitNew[root->data] = len;
        cout << endl;
    }
}
int main() {
	// Them tat ca data-frequently vao hang doi uu tien
	// Trong khi hang doi != null, lay ra 2 con co tan suat nho nhat, gop vao thanh 1 - > them vao pq
	cout << "So bit  = "; cin >> bit;
	cout << "Nhập m = "; cin >> m;
	cout << "Nhập n = "; cin >> n;
	int bitBegin = bit * m * n;
	int l = 1e8, r = -1e8;
	FOR(i,0,m) FOR(j,0,n) {
		cin >> a[i][j];
		l = min(l, a[i][j]);
		r = max(r, a[i][j]);
		c[a[i][j]]++;
	}
	FOR(i,l,r+1) {
		Node * newNode = new Node(i, c[i]);
		pq.push(newNode);
	}
	// Encoding Huffman
	while (pq.size() != 1) {
		// Lay ra 2 node co tan suat nho nhat
		Node *node1 = pq.top();
		pq.pop();
		Node *node2 = pq.top();
		pq.pop();
		// Tao node moi tu 2 node tren
		Node *newNode = new Node(-1, node1->freq + node2->freq);
		newNode->left = node1;
		newNode->right = node2;
		pq.push(newNode);
	}
	// Lay node goc
	Node* root = pq.top();
	// In ra day huffman
    int array[100], len = 0;
    printCodes(root, array, len);
    // In ra so bit trung binh
    // tan suat  = sum
    int sum = 0 ;
    FOR(i,l,r+1) sum += c[i];
    cout << "Dtb = ";
    double res = 0;
    FOR(i,l,r+1) {
		// i  - c[i]
		// bitNew[i] - len so bit
		cout << bitNew[i] << "*" << (1.0*c[i])/sum;
		if (i != r) cout << " + ";
		res += 1.0*bitNew[i] * ((1.0*c[i])/sum);
	}
	cout << " = " << res << endl;
    // Ti so nen
	double tiSoNen = (bitBegin*1.0) / (res*m*n);
	cout << "Tỉ số nén  = " << tiSoNen << endl;
	
	// Do du thua
	double doDuThua = (1.0 - (1/tiSoNen)) * 100;
	cout << "Độ dư thừa = "<< doDuThua << endl;
}
/*
1 2 2 4 6 
3 1 3 4 7 
3 2 3 4 7 
4 4 5 5 7 
7 6 7 7 6
*/
