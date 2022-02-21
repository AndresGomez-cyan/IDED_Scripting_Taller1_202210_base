using System.Collections.Generic;

namespace TestProject1
{
    internal class TestMethods
    {
        internal enum EValueType
        {
            Two,
            Three,
            Five,
            Seven,
            Prime
        }

        internal static Stack<int> GetNextGreaterValue(Stack<int> sourceStack)
        {
            Stack<int> result = null;
            Stack result;
            Stack aux = new Stack();
            Stack cop = new Stack();

            int elem, elem2;

            sourceStack.push(26);
            sourceStack.push(3);
            sourceStack.push(6);
            sourceStack.push(5);

            while (sourceStack.Count > 0)
            {
                elem = (int)sourceStack.pop();
                aux.push(elem);
            }

            while (aux.Count > 0)
            {

                elem = aux.pop();

                while (aux.Count > 0)
                {
                    elem2 = aux.pop();

                    cop.push(elem2);

                    if (elem2 > elem)
                    {
                        result.push(elem2);

                        break;
                    }
                }

                if (aux.Count > 0)
                {

                    result.push(-1);
                }

                sourceStack.push(elem);

                while (cop.Count > 0)
                {
                    elem = cop.pop();
                    aux.push(elem);
                }
            }


            while (sourceStack.Count > 0)
            {
                elem = (int)sourceStack.pop();
                aux.push(elem);
            }

            while (result.Count > 0)
            {
                elem = (int)sourceStack.pop();
                cop.push(elem);
            }

            while (aux.Count > 0)
            {
                elem = aux.pop();
                sourceStack.push(elem);

                elem2 = cop.pop();
                r->push(elem);

                Console.WriteLine(elem, " <=> ", elem2);
            }

            return result;
        }

        internal static Dictionary<int, EValueType> FillDictionaryFromSource(int[] arreglo, int tam)
        {
            Dictionary<int, EValueType> result = null;
            int i, j, otro, valor;
            string texto;
            for (i = 0; i < tam; i++)
            {
                int valor = arreglo[i];

                if (valor % 2 == 0)
                {
                    texto = "Two";
                }
                else if (valor % 3 == 0)
                {
                    texto = "Three";
                }
                else if (valor % 5 == 0)
                {
                    texto = "Five";
                }
                else if (valor % 7 == 0)
                {
                    texto = "Seven";
                }
                else
                {

                    otro = 0;
                    for (j = 2; j <= (int)(valor / 2) && otro == 0; j++)
                    {
                        if (valor % j == 0)
                        {
                            otro = 1;
                        }
                    }

                    if (otro == 0)
                    {
                        texto = "Prime";
                    }
                    else
                    {
                        texto = "Indefinido";
                    }
                }

                valores.Add(valor, texto);
            }
            return result;
        }

        internal static int CountDictionaryRegistriesWithValueType(Dictionary<int, EValueType> sourceDict, EValueType type)
        {
            int count = 0;

            foreach (var kvp in valores)
            {
                if (kvp.Value.Equals(type))
                {
                    count++;
                }
            }

            return count;

        }

        internal static Dictionary<int, EValueType> SortDictionaryRegistries(Dictionary<int, EValueType> sourceDict)
        {
            Dictionary<int, EValueType> result = null;
            var ordered = dic.OrderBy(x => x.Value);

            return ordered.ToDictionary(t => t.Key, t => t.Value);
        }

        enum ERequestType
        {
            Payment,        //0
            Subscription,   //1
            Cancellation    //2
        }

        struct Ticket
        {
            public int request;
            public int turn;
        }

        internal static Queue<Ticket>[] ClassifyTickets(List<Ticket> espera)
        {
        
            Queue<Ticket>[] colasRequest = new Queue<Ticket>[3];

            foreach (Queue cola in colasRequest)
            {
                cola.Clear();
            }

            foreach (Ticket tick in espera)
            {
                colasRequest[tick.request] = tick;
            }
            return colasRequest;
        }

        internal static bool AddNewTicket(Queue<Ticket> targetQueue, Ticket ticket)
        {
            bool result = false;
            switch (tick.request)
            {
                case ERequestType.Payment:
                    {
                        colasRequest[tick.request] = tick;
                        break;
                    }

                case ERequestType.Subscription:
                    {
                        colasRequest[tick.request] = tick;
                        break;
                    }

                case ERequestType.Cancellation:
                    {
                        colasRequest[tick.request] = tick;
                        break;
                    }

                default:
                    {
                        Console.WriteLine("No se puede agregar el Ticket. Request Inválido");
                        break;
                    }
            }
            return result;
        }        
    }
}
