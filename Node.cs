using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev3
{
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }

    public class DaireselBaglantılıListe
    {
        private Node head;

        public DaireselBaglantılıListe()
        {
            head = null;
        }

        // Listeyi ekranda göster
        public void Goruntule()
        {
            if (head == null)
            {
                Console.WriteLine("Liste boş.");
                return;
            }

            Node current = head;
            do
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            } while (current != head);

            Console.WriteLine();
        }

        // Başa ekle
        public void EklentiBaslangıcı(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                newNode.Next = head;  // Kendine işaret eder
            }
            else
            {
                Node current = head;
                while (current.Next != head)
                {
                    current = current.Next;  // Son düğüme ulaş
                }
                current.Next = newNode;  // Son düğümün next'ini yeni düğüme ayarla
                newNode.Next = head;  // Yeni düğümün next'ini head'e ayarla
                head = newNode;  // Yeni düğümü head yap
            }
        }

        // Sona ekle
        public void SonaEkle(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                newNode.Next = head;  // Kendine işaret eder
            }
            else
            {
                Node current = head;
                while (current.Next != head)
                {
                    current = current.Next;  // Son düğüme ulaş
                }
                current.Next = newNode;  // Son düğümün next'ini yeni düğüme ayarla
                newNode.Next = head;  // Yeni düğümün next'ini head'e ayarla
            }
        }

        // İstenilen sırada ekleme
        public void İstenilenSıradaEkle(int existingData, int newData)
        {
            Node current = head;
            if (current == null)
            {
                Console.WriteLine("Liste boş, ekleme yapılamaz.");
                return;
            }

            do
            {
                if (current.Data == existingData)
                {
                    Node newNode = new Node(newData);
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    return;
                }
                current = current.Next;
            } while (current != head);

            Console.WriteLine($"{existingData} bulunamadı.");
        }

        // Baştan sil
        public void BastanSil()
        {
            if (head == null)
            {
                Console.WriteLine("Liste boş, silme yapılamaz.");
                return;
            }

            Node current = head;
            if (current.Next == head) // Tek düğüm varsa
            {
                head = null;
            }
            else
            {
                while (current.Next != head)
                {
                    current = current.Next;  // Son düğüme ulaş
                }
                current.Next = head.Next;  // Son düğümün next'ini ikinci düğüme ayarla
                head = head.Next;  // Head'i ikinci düğüm yap
            }
        }

        // Sondan sil
        public void SondanSil()
        {
            if (head == null)
            {
                Console.WriteLine("Liste boş, silme yapılamaz.");
                return;
            }

            Node current = head;
            if (current.Next == head) // Tek düğüm varsa
            {
                head = null;
            }
            else
            {
                while (current.Next.Next != head)
                {
                    current = current.Next;  // Son düğümün öncesine ulaş
                }
                current.Next = head;  // Son düğümün next'ini head yap
            }
        }

        // İstenilen sırada silme
        public void İstediginSıradanSil(int data)
        {
            if (head == null)
            {
                Console.WriteLine("Liste boş, silme yapılamaz.");
                return;
            }

            Node current = head;
            Node previous = null;

            do
            {
                if (current.Data == data)
                {
                    if (previous == null) // Başta ise
                    {
                        BastanSil();
                    }
                    else if (current.Next == head) // Sondaysa
                    {
                       SondanSil();
                    }
                    else // Ortadaysa
                    {
                        previous.Next = current.Next;
                    }
                    return;
                }
                previous = current;
                current = current.Next;
            } while (current != head);

            Console.WriteLine($"{data} bulunamadı.");
        }
    }

}
