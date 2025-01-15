using ObjectModel;
using FileProcessingLibrary;
namespace ProductManage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Product x = new Product();

        List<Product> product = new List<Product>();

        List<Product> productLst = new List<Product>();
        List<Customer> customer = new List<Customer>();

        //PYTHON: sanPhams =List<SanPham>();


        void VirtualData()
        {
            product.Clear();
            product.Add(new Product()
            {
                Code = "SP1",
                Name = "Thuốc trị hội nách",
                Quantity = 10,
                Price = 100
            }
                        );
            product.Add(new Product() { Code = "SP2", Name = "Thuốc trị lang beeng", Quantity = 5, Price = 30 });
            product.Add(new Product() { Code = "SP3", Name = "Thuốc trị xàm", Quantity = 70, Price = 20 });
            product.Add(new Product() { Code = "SP4", Name = "Thuốc trị ghẻ", Quantity = 7, Price = 25 });
            product.Add(new Product() { Code = "SP5", Name = "Thuốc trị lazy", Quantity = 20, Price = 40 });
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //VirtualData();
            //ShowProductInListView();
        }

        void ShowProductInListView()
        {
            //Bước 1: Xóa dữ liệu cũ trên giao diện Listview đi
            //(vì có thể nó được tải lại nhiều lần, ta phải lấy dữ liệu cuối cùng mới nhất)
            lvProduct.Items.Clear();
            foreach (Product sp in productLst)
            {
                //tạo 1 dòng cho Listview, nó gọi là ListviewItem:
                ListViewItem lvi = new ListViewItem(sp.Code);//ô đầu tiên của dòng
                lvi.Tag = sp;//lưu lại đối tượng đang quản lý ô nhớ trên thanh RAM vào thuộc tính Tag
                             //để ta truy lục lại cho dễ
                lvi.SubItems.Add(sp.Name);
                lvi.SubItems.Add(sp.Quantity.ToString());
                lvi.SubItems.Add(sp.Price.ToString());
                //đưa listviewitem lên listview:
                lvProduct.Items.Add(lvi);
            }
        }
        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            txtCode.Text = string.Empty;
            txtName.Clear();
            txtQuantity.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtCode.Focus();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void sYSTEMToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        bool CheckDuplicateCode(string msp)
        {
            for (int i = 0; i < product.Count; i = i + 1)
            {
                //dùng index để lấy từng phần tử thứ i ra:
                Product p = product[i];
                if (p.Code == msp)
                {
                    return true;
                }
            }
            return false;
        }
        bool CheckDuplicateCode2(string msp)
        {
            foreach (Product p in product)
            {
                if (p.Code == msp)
                {
                    return true;
                }
            }
            return false;
        }
        private void btnNewSave_Click(object sender, EventArgs e)
        {
            // create a products in slot memories
            //Tạo 1 sản phẩm mới trong ô nhớ (trên thanh RAM):
            Product p = new Product();
            //thay đổi các giá trị cho các thuộc tính của p:
            p.Code = txtCode.Text;
            p.Name = txtName.Text;
            p.Quantity = int.Parse(txtQuantity.Text);
            p.Price = double.Parse(txtPrice.Text);
            bool kt_trung = CheckDuplicateCode(p.Code);
            if (kt_trung)
            {
                MessageBox.Show("Mã bị trùng rồi Thím ơi!");
                return;//dừng hàm ko làm gì tiếp theo cả vì mã đã trùng
            }
            //nối đuôi ô nhớ mà p đang quản lý vào dãy ô nhớ mà sanPhams đang quản lý
            //nói ngắn gọn: thêm mới p vào sanPhams
            productLst.Add(p);
            //hiển thị lại dữ liệu lên giao diện ListView:
            ShowProductInListView();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("" +
                "Do you want to exit",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                Close();
            }
        }

        private void menuSystemReadJsonFile_Click(object sender, EventArgs e)
        {
            string filename = "mydata.json";
            JSonFileFactory jff = new JSonFileFactory();
            object data = jff.ReadData<List<Product>>(filename);
            productLst = data as List<Product>;
            if (productLst != null)
            {
                return;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
