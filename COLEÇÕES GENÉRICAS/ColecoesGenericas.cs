using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Criptografia_Exemplo
{
    public partial class ColecoesGenericas : Form
    {
        public bool teste = false;

        public ColecoesGenericas()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Botão exemplo "LIST"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnList_Click(object sender, EventArgs e)
        {
            Lista.Items.Clear();

            List<string> lista = new List<string>();

            lista.Add("André Cini");
            lista.Add("Nathan Vilela");
            lista.Add("Alexander Vilaça");
            lista.Add("Claus Alberto");
            lista.Add("Guilherme Turtera");
            lista.Add("Lucão Antônio");
            lista.Add("Ivan Zanutto");
            lista.Add("Matheus Novais");

            foreach (string aux in lista)
            {
                Lista.Items.Add(aux);
            }
        }

        /// <summary>
        /// Botão exemplo "HASHSET"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHS_Click(object sender, EventArgs e)
        {
            #region Propriedades

            ///Add(T): Adiciona o elemento especificado a um conjunto.

            ///Clear(): Remove todos os elementos de um objeto HashSet<T>.

            ///Contains(T): Determina se um objeto HashSet<T> contém o 
            ///elemento especificado.

            ///CopyTo(T[]):Copia os elementos de um objeto HashSet<T> 
            ///para uma matriz.

            ///CopyTo(T[], Int32):Copia os elementos de um objeto 
            ///HashSet<T> para uma matriz, começando no índice da matriz 
            ///especificada.

            ///CopyTo(T[], Int32, Int32):Copia o número especificado de 
            ///elementos de um objeto HashSet<T> para uma matriz, começando
            ///no índice especificado da matriz.

            ///CreateSetComparer():Retorna um objeto IEqualityComparer que 
            ///pode ser usado para teste de igualdade de um objeto HashSet<T>.

            ///EnsureCapacity(Int32):Garante que esse conjunto de hash pode 
            ///conter o número de elementos especificado sem crescer.

            ///Equals(Object):Determina se o objeto especificado é igual ao 
            ///objeto atual.(Herdado de Object)

            ///ExceptWith(IEnumerable<T>):Remove todos os elementos na coleção 
            ///especificada do objeto HashSet<T> atual.

            ///GetEnumerator():Retorna um enumerador que itera por meio de um 
            ///objeto HashSet<T>.

            ///GetHashCode():Serve como a função de hash padrão.(Herdado de Object)

            ///GetObjectData(SerializationInfo, StreamingContext):Implementa a
            ///interface ISerializable e retorna os dados necessários para serializar
            ///um objeto HashSet<T>.

            ///GetType():Obtém o Type da instância atual.(Herdado de Object)

            ///IntersectWith(IEnumerable<T>):Modifica o objeto HashSet<T> atual
            ///para que ele contenha somente elementos presentes no objeto e na 
            ///coleção especificada.

            ///IsProperSubsetOf(IEnumerable<T>):Determina se um objeto HashSet<T>
            ///é um subconjunto apropriado da coleção especificada.

            ///IsProperSupersetOf(IEnumerable<T>:Determina se um objeto HashSet<T>
            ///é um superconjunto apropriado da coleção especificada.

            ///IsSubsetOf(IEnumerable<T>):Determina se um objeto HashSet<T> é um 
            ///subconjunto da coleção especificada.

            ///IsSupersetOf(IEnumerable<T>):Determina se um objeto HashSet<T> é um
            ///superconjunto da coleção especificada.

            ///MemberwiseClone():Cria uma cópia superficial do Object atual.
            ///(Herdado de Object)

            ///OnDeserialization(Object):Implementa a interface ISerializable e gera
            ///o evento de desserialização quando a desserialização for concluída.

            ///Overlaps(IEnumerable<T>):Determina se o objeto HashSet<T> atual e uma
            ///coleção especificada compartilham elementos comuns.

            ///Remove(T):Remove o elemento especificado de um objeto HashSet<T>.

            ///RemoveWhere(Predicate<T>):Remove todos os elementos que correspondem
            ///às condições definidas pelo predicado especificado de uma coleção de 
            ///HashSet<T>.

            ///SetEquals(IEnumerable<T>):Determina se um objeto HashSet<T> e coleção 
            ///especificada contêm os mesmos elementos.

            ///SymmetricExceptWith(IEnumerable<T>):Modifica o objeto HashSet<T> atual
            ///para que ele contenha somente elementos que estão presentes no objeto 
            ///ou na coleção especificada, mas não em ambos.

            ///ToString():Retorna uma cadeia de caracteres que representa o objeto 
            ///atual.(Herdado de Object)

            ///TrimExcess():Define a capacidade de um objeto HashSet<T> para o número
            ///real de elementos que ele contém, arredondado para cima para um valor 
            ///próximo específico da implementação.

            ///TryGetValue(T, T):Pesquisa um determinado valor no conjunto e retorna 
            ///o valor igual que for encontrado, se houver.

            ///UnionWith(IEnumerable<T>):Modifica o objeto HashSet<T> atual para que 
            ///ele contenha todos os elementos presentes nele, na coleção especificada
            ///ou em ambos.

            #endregion

            string texto;
            if (teste)
            {
                texto = "Avião";
            }
            else
            {
                texto = "Cavalo";
            }

            Lista.Items.Clear();

            HashSet<string> veiculos = new HashSet<string>()
                {
                "Carro",
                "Moto",
                "Avião",
                "Helicóptero",
                "Navio",
                "Elevador",
                "Bicicleta",
                "Em um HashSet não pode haver elementos repetidos"
                };


            if (veiculos.Add(texto)) //.Add retorna um bool
            {
                MessageBox.Show(string.Format("Item '{0}' Adicionado!", texto));
            }
            else
            {
                MessageBox.Show(string.Format("Item '{0}' não Adicionado!", texto));
            }

            foreach (string aux in veiculos)
            {
                Lista.Items.Add(aux);
            }

            teste = !teste;
        }

        /// <summary>
        /// Botão exemplo "DICTIONARY"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDic_Click(object sender, EventArgs e)
        {
            #region Propriedades
            ///Count: Obtém o número total de elementos no 
            ///Dictionary<TKey,TValue>.

            ///IsReadOnly: Retorna um booleano indicando se
            ///o Dictionary<TKey,TValue> é somente leitura.

            ///Item: Obtém ou define o elemento com a chave 
            ///especificada no Dictionary<TKey,TValue>.

            ///Keys: Retorna a coleção de chaves do 
            ///Dictionary<TKey,TValue>

            ///Values: Retorna a coleta de valores no 
            ///Dictionary<TKey,TValue>.

            ///Add: Adiciona um item à coleção Dictionary.

            ///Add: Adiciona pares de valores-chave na coleção
            ///Dictionary<TKey,TValue>.

            ///Remove: Remove a primeira ocorrência do item
            ///especificado do Dictionary<TKey,TValue>.

            ///Remove: Remove o elemento com a chave especificada.

            ///ContainsKey: Verifica se a chave especificada
            ///existe em Dictionary<TKey,TValue>.

            ///ContainsValue: Verifica se o valor especificado
            ///existe em Dictionary<TKey,TValue>.

            ///Clear: Remove todos os elementos do Dictionary<TKey,TValue>.

            ///TryGetValue: retorna true e atribui o valor com
            ///a chave especificada, se a chave não existir, retorna false.
            #endregion

            Lista.Items.Clear();
            Dictionary<int, string> alunos = new Dictionary<int, string>()
            {
                {08120001, "André Cini"},
                {08120002, "Nathan Vilela"},
                {08120003, "Guilherme Turtera"},
                {08110001, "Claus Alberto"},
                {08100001, "Matheus Novais"},
                {08110002, "Lucas Antônio"},
                {08020001, "Ivan Zanutto"},
                {08120004, "Alexsander Vilaça"}
                
            };
            //alunos.Add(100, "GABRIEL");

            foreach (KeyValuePair<int, string> item in alunos)
            {
                Lista.Items.Add(item.Key + " -> " + item.Value);
            }

            Lista.Items.Add("");
            Lista.Items.Add(" Podemos resumir, de forma simplista, a definição ");
            Lista.Items.Add("do dictionary à uma lista indexada. Ele nos permite ");
            Lista.Items.Add("narmazenar pares de chave + valor, sendo que estes ");
            Lista.Items.Add("npodem ser de qualquer tipo.");
            Lista.Items.Add("");
            Lista.Items.Add(" O melhor é que esta lista é indexada pela chave ");
            Lista.Items.Add("que você define, se tornando muito fácil e rápido ");
            Lista.Items.Add("localizar itens dentro dela.");

        }

        /// <summary>
        /// Botão exemplo "SORTEDLIST"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSL_Click(object sender, EventArgs e)
        {
            Lista.Items.Clear();

            SortedList<int, string> alunos = new SortedList<int, string>()
            {
                {08120001, "André Cini"},
                {08120002, "Nathan Vilela"},
                {08120003, "Guilherme Turtera"},
                {08110001, "Claus Alberto"},
                {08100001, "Matheus Novais"},
                {08110002, "Lucas Antônio"},
                {08020001, "Ivan Zanutto"},
                {08120004, "Alexsander Vilaça"}
            };

            foreach (KeyValuePair<int, string> aux in alunos)
            {
                Lista.Items.Add(aux.Key + "->" + aux.Value);
            }

        }

        /// <summary>
        /// Botão exemplo "SORTEDDICTIONARY"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSD_Click(object sender, EventArgs e)
        {
            Lista.Items.Clear();

            SortedDictionary<int, string> alunos = new SortedDictionary<int, string>()
            {
                 {08120001, "André Cini"},
                {08120002, "Nathan Vilela"},
                {08120003, "Guilherme Turtera"},
                {08110001, "Claus Alberto"},
                {08100001, "Matheus Novais"},
                {08110002, "Lucas Antônio"},
                {08020001, "Ivan Zanutto"},
                {08120004, "Alexsander Vilaça"}

            };

            foreach (KeyValuePair<int, string> item in alunos)
            {
                Lista.Items.Add(item.Key + "->" + item.Value);
            }

        }

        /// <summary>
        /// Botão exemplo "QUEUE"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQueue_Click(object sender, EventArgs e)
        {
            Lista.Items.Clear();

            Queue<string> fila = new Queue<string>();
            fila.Enqueue("André");
            fila.Enqueue("Nathan");
            fila.Enqueue("Alexander");
            fila.Enqueue("Claus");
            fila.Enqueue("Guilherme");
            fila.Enqueue("Lucão");
            fila.Enqueue("Ivan");
            fila.Enqueue("Matheus");

            MessageBox.Show(fila.Count.ToString());

            foreach (var aux in fila)
            {
                Lista.Items.Add(aux);
            }

        }

        /// <summary>
        /// Botão exemplo "STACK" (pilha)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStack_Click(object sender, EventArgs e)
        {
            Lista.Items.Clear();

            Stack<string> pilha = new Stack<string>();

            pilha.Push("André");
            pilha.Push("Nathan");
            pilha.Push("Alexander");
            pilha.Push("Claus");
            pilha.Push("Guilherme");
            pilha.Push("Lucão");
            pilha.Push("Ivan");
            pilha.Push("Matheus");

            foreach (string aux in pilha)
            {
                Lista.Items.Add(aux);
            }
        }






    }
}
