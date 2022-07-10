using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    internal class Tablo
    {
        public int size;
        Node[] dizi;

        public Tablo(int size)
        {
            this.size = size;
            dizi = new Node[size]; //array'e size atama

            for (int i = 0; i < size; i++)
            {
                dizi[i] = new Node(); //array içine gösterici düğüm ekleme
            }
        }


        //Hash yapısına göre eklenecek elemanın hangi index'te olacağını bulma
        public int indexBul(int key)
        {
            return key % size;
        }

        string mesaj;
        public string Ekle(int key, string name)
        {
            Node eleman = new Node(key, name); //array dışına linked list düğümü ekleme
            int index = indexBul(key);
            Node temp = dizi[index]; //temp, gösterici düğümdür

            //elemanları linked list şeklinde sona ekleme
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = eleman;

            return mesaj = "Eleman eklendi... Name: " + name + ", Key: " + key + ", Tutulduğu Index: " + index + "\n";
        }

        string mesaj2;
        public string Sil(int key)
        {
            int index = indexBul(key);
            Node temp = dizi[index]; //temp, gösterici düğümdür

            if (temp.next == null)
            {
                return mesaj2 = "Eleman bulunamadı...";
            }

            if (temp.next.next == null && temp.next.key == key) //ilgili index'te 1 tane linked list elemanı varsa VE o eleman da silinecek olan key'e eşit ise
            {
                temp.next = null;
                return mesaj2 = "Eleman silindi... Key: " + key + ", Silindiği Index: " + index + "\n";
            }
            else //ilgili index'te 1'den fazla linked list elemanı varsa -> aradan bir eleman silinirse kalan elemanların arasında tekrar bağlantı kurmak gerekecek o yüzden bunu kontrol etmeliyiz
            {
                Node temp2 = temp;
                while(temp.next != null)
                {
                    //temp2'yi, temp'in solundaki eleman yapma
                    temp2 = temp;
                    temp = temp.next;

                    if (temp.key == key)
                    {
                        temp2.next = temp.next; //iki elemanı bağlayarak arada oluşan boşluğu yok etme
                    }
                }
                return mesaj2 = "Eleman silindi... Key: " + key + ", Silindiği Index: " + index + "\n";
            }
        }
    }
}
