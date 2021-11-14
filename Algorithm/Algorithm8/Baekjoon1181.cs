using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm8
{
    class Baekjoon1181
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>(); 
            var count = int.Parse(Console.ReadLine()!);
     
            for (int i = 0; i < count; i++)
            {
                string word = Console.ReadLine();
                if (words.Exists(x=> x== word) == false)
                {
                    words.Add(word);
                }
            }
            
            words.Sort();
            int left = 0;
            int right = words.Count - 1;
            
            Sort(left, right);

            void Sort(int _left, int _right)
            {
                if (_left >= _right)
                {
                    return;
                }
                var pivot = Swap(_left, _right);
                Sort(_left, pivot - 1);
                Sort(pivot + 1, _right);
            }
            int Swap(int _left, int _right)
            {
                int _pivot = _left;
                _left++;
                while (true)
                {
                    if (words[_pivot].Length >= words[_left].Length)
                    {
                        if (words[_pivot].Length == words[_left].Length)
                        {
                            for (int i = 0; i < words[_pivot].Length; i++)
                            {
                                if (words[_pivot][i] < words[_left][i])
                                {
                                    break;
                                }
                                else if(words[_pivot][i] > words[_left][i])
                                {
                                    _left++;
                                    break;
                                }
                            }
                        }
                        else
                        {
                            _left++;
                        }
                    }
                    if (words[_pivot].Length <= words[_right].Length)
                    {
                        if (words[_pivot].Length == words[_right].Length)
                        {
                            for (int i = 0; i < words[_pivot].Length; i++)
                            {
                                if (words[_pivot][i] > words[_left][i])
                                {
                                    break;
                                }
                                else if (words[_pivot][i] < words[_right][i])
                                {
                                    _right--;
                                    break;
                                }
                            }
                        }
                        else
                        {
                            _right--;
                        }
                    }

                    if (_left > _right)
                    {
                        break;
                    }
                    if (words[_left].Length > words[_right].Length)
                    {
                        (words[_left], words[_right]) = (words[_right], words[_left]);
                    }
                }
                (words[_pivot], words[_right]) = (words[_right], words[_pivot]);
                return _right;
            }
            Console.WriteLine(string.Join("\n", words));
            // List<string> words = new List<string>();
            // var count = int.Parse(Console.ReadLine()!);
            //
            // for (int i = 0; i < count; i++)
            // {
            //     string word = Console.ReadLine();
            //     if (words.Exists(x=> x== word) == false)
            //     {
            //         words.Add(word);
            //     }
            // }
            // //알파벳 순으로 정렬
            // var list = words.OrderBy(x => x);
            // var result = list.OrderBy(x => x.Length);
            //
            // Console.WriteLine(string.Join("\n", result));
        }
    }
}

//QuickSort.....열쉬미..만들었는데...시..무..룩
// List<string> words = new List<string>(); 
//            var count = int.Parse(Console.ReadLine()!);
//     
//            for (int i = 0; i < count; i++)
//            {
//                string word = Console.ReadLine();
//                if (words.Exists(x=> x== word) == false)
//                {
//                    words.Add(word);
//                }
//            }
//            
//            words.Sort();
//            int left = 0;
//            int right = words.Count - 1;
//            
//            Sort(left, right);
//
//            void Sort(int _left, int _right)
//            {
//                if (_left >= _right)
//                {
//                    return;
//                }
//                var pivot = Swap(_left, _right);
//                Sort(_left, pivot - 1);
//                Sort(pivot + 1, _right);
//            }
//            int Swap(int _left, int _right)
//            {
//                int _pivot = _left;
//                _left++;
//                while (true)
//                {
//                    if (words[_pivot].Length >= words[_left].Length)
//                    {
//                        if (words[_pivot].Length == words[_left].Length)
//                        {
//                            for (int i = 0; i < words[_pivot].Length; i++)
//                            {
//                                if (words[_pivot][i] < words[_left][i])
//                                {
//                                    break;
//                                }
//                                else if(words[_pivot][i] > words[_left][i])
//                                {
//                                    _left++;
//                                    break;
//                                }
//                            }
//                        }
//                        else
//                        {
//                            _left++;
//                        }
//                    }
//                    if (words[_pivot].Length <= words[_right].Length)
//                    {
//                        if (words[_pivot].Length == words[_right].Length)
//                        {
//                            for (int i = 0; i < words[_pivot].Length; i++)
//                            {
//                                if (words[_pivot][i] > words[_left][i])
//                                {
//                                    break;
//                                }
//                                else if (words[_pivot][i] < words[_right][i])
//                                {
//                                    _right--;
//                                    break;
//                                }
//                            }
//                        }
//                        else
//                        {
//                            _right--;
//                        }
//                    }
//
//                    if (_left > _right)
//                    {
//                        break;
//                    }
//                    if (words[_left].Length > words[_right].Length)
//                    {
//                        (words[_left], words[_right]) = (words[_right], words[_left]);
//                    }
//                }
//                (words[_pivot], words[_right]) = (words[_right], words[_pivot]);
//                return _right;
//            }
//            Console.WriteLine(string.Join("\n", words));