using System.Net.Http.Headers;
using System.Security.Cryptography;

namespace 数组 {
	internal class Program {
		static void Main ( string[] args ) {

			//冒泡排序，数组，选择排序
			#region 数组的方法
			//获取数组的长度
			//数组名.Length;

			//当数组长度太大无法使用.Length时使用
			//数组名.LongLength;

			//获取数组的维度
			//数组名.Rank;

			//更改数组的长度
			//Array.Resize ( ref 需要改变的数组, 需要改变的数组长度值 );

			//清除数组里的内存
			//Array.Clear( 数组名, 开始清除的索引值, 需要清除的个数 );

			//排序（正序,配合颠倒可以达到倒序）
			//Array.Sort(数组名);

			//颠倒数组
			//Array.Reverse (数组名);

			//查找数组中的元素
			//Array.IndexOf(数组名，查找目标，从哪个索引开始找);
			//Array.IndexOf(数组名，查找目标，从哪个索引开始找，往后查找多少个);
			#endregion


			#region ?可空数据类型（用int举例）
			//空值(?)
			int? iic;
            iic = null;
            Console.WriteLine(iic);         //iic=null

            //判断是否为空（？？）
            int anum = iic ?? 20;
            Console.WriteLine(anum);
            //当iic=null时，anum=20
            //当iic!=null时，anum=iic

            //断点(类似三元运算符逻辑 )
            int? bnum = iic== null ? null : 1;
            Console.WriteLine(bnum);
            //当iic=null时，bnum=null,即可阻断bnum=1的过程，从而达到阻断后续代码的执行;
            //当iic!=null时，bnum=1;

            //判断是否为空，为空时赋值，不为空时不赋值（？？=）
            int? cnum = null;
            cnum ??= 30;
            Console.WriteLine(cnum);
            //cnum的值为null,则cnum=30
            int? dnum = 20;
            dnum ??= 30;
            Console.WriteLine(dnum);
            //dnum的值不为null,则dnum=20

            Console.WriteLine();
            #endregion



            #region 冒泡排序

            #region 排序的基本概念
            //进行从小到大的排序
            #endregion

            #region 冒泡排序的基本原理
            //两两相邻
            //不停比较
            //不停交换
            //比较n轮
            #endregion

            #region 代码实现
            int[] arr = new int[]{543,6,76,34,534,7,895,43,23,76,7,34,324};
			for ( int i = 0; i < arr.Length; i++ ) {
				Console.Write(arr[i] + " ");
			}
            Console.WriteLine();
            //快速冒泡排序
			for ( int i = 0; i < arr.Length - 1; i++ ) {
				for ( int j = 0; j < arr.Length - 1 - i; j++ ) {
					if ( arr[j] < arr[j + 1] ) {
						int temps = arr[j];
						arr[j] = arr[j + 1];
						arr[j + 1] = temps;
					}
				}
			}
			//第一步要循环n轮实现n个数的排序
			for (int j = 0; j < arr.Length; j++)
            {
                //第二步需要遍历数组，进行交换位置，由于是前一个和后一个进行比较所以，循环的次数为数组的长度-1
				for ( int i = 0; i < arr.Length - 1; i++ ) {
                    //第三步进行判断前一个和后一个的大小，如果前一个大于后面的就进行换位置
					if ( arr[i] > arr[i + 1] ) {
                        //进行交换位置，方法1：语法糖
                        //(arr[i], arr[i+1]) = (arr[i+1], arr[i]);
                        //进行换位置，方法2：中间商不赚差价
						int temps = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temps;
					}
				}
			}
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] +" ");
            }
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #endregion

            #region 数组

            #region 一维数组

            #region 基本概念
            //数组是存储一组相同类型数据的集合
            //数组分为 一维 多维 交错数组
            //一般情况下 一维数组 就简称为数组
            #endregion

            #region 数组的声明
            //变量类型[] 数组名；	只是声明了一个数组但是没有开房间
            //int[] arr;
            //变量类型[] 数组名 = new 变量类型[数组的长度];
            //int[] arr2 = new int[5];
            //变量类型[] 数组名 = new 变量类型[数组的长度]{内容1，内容2，内容3，......};
            //int[] arr3 = new int[5]{ 1 , 2 , 3 , 4 , 5};
            //变量类型[] 数组名 = new 变量类型[]{内容1，内容2，内容3，......};		后面的 花括号内的  内容个数  决定了  数组的长度
            //int[] arr4 = new int[]{1 , 2 , 3 ,4 , 5 , 6};
            //变量类型[] 数组名 = {内容1，内容2，内容3，......};					后面的 花括号内的  内容个数  决定了  数组的长度
            //int[] arr5 = {1 ,2 ,3 ,4 ,5 ,6 , 7};
            //变量类型可以是所有变量类型
            //bool[] arr6 = {true , false , false , false , false , false , false , true };
            #endregion

            #region 数组的使用
            //1.数组的长度
            //int[] array = { 1,2,3,4,5,6,7,8,9,10};
            //Console.WriteLine(array.Length);//打印数组的长度	数组名.Length


            //2.获取数组中的元素
            //数组中的下表或者说索引，是从0开始的
            //注意：不能越界，数组的索引值范围为 0 - (数组名.Length-1)
            //Console.WriteLine(array[5]);


            //3.修改数组中的元素

            //array[8] = 99;//注意：只能是和数组是同一个数据类型时才能修改
            //Console.WriteLine(array[8]);



            //4.遍历数组
            //通过循环遍历数组中的每一个元素
            //for ( int i = 0; i < array.Length; i++ ) {
            //	Console.Write(array[i]+" ");
            //}
            //Console.WriteLine();
            //foreach (int arraynum in array)
            //{ Console.Write(arraynum + " ");}
			//Console.WriteLine();


			//5.增加数组的元素
			//数组初始化之后 是不能够 直接添加新元素 所以 如果需要添加新元素 就要声明新的数组进行搬家
			//int[] array2 = new int[array.Length+1];
			//for ( int i = 0; i < array.Length; i++ ) {
			//	array2[i]=array[i];
			//}
			//将新数组的地址给老数组，老数组的长度就会加1
			//array = array2;
			//将新数组的最后一个位置进行赋值
			//array[10] = 11;
			//for ( int i = 0;i < array.Length; i++ ) {
			//	Console.Write(array[i]+" ");
			//}
			//Console.WriteLine();



			//6.删除数组中的元素
			//套路同增加元素。
			//数组初始化之后 是不能够 直接删除元素 所以 如果需要删除元素 就要声明新的数组进行搬家
			//如果需要删除数组的中间的一个值呢？
			//         int[] array3 = new int[array.Length-1];
			//for ( int i = 0;i<array3.Length ; i++ ) {
			//	array3[i] = array[i];
			//         }
			//array = array3;
			//for ( int i = 0; i < array3.Length; i++ ) {
			//	Console.Write(array[i] +" ");
			//         }
			//         Console.WriteLine();



			//7.查找数组中的元素
			//当数组中的元素个数较多时怎么去查找
			//int arrNum =99;
			//for ( int i = 0; i < array.Length; i++ ) {
			//	if ( array[i] == arrNum ) {
			//		Console.WriteLine(i);
			//		break;
			//	}	
			//}

			#endregion

			#region 一维数组联系题
			//1
			int[] arrNum = new int[101];
			for ( int i = 0; i < arrNum.Length; i++ ) {
				arrNum[i] = i;
			}
			for ( int i = 0; i < arrNum.Length; i++ ) {
				Console.Write(arrNum[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
			//2
			int[] arrNum_2 = new int [arrNum.Length];
			for ( int i = 0;i < arrNum.Length;i++ ) { 
				arrNum_2[i] = arrNum[i]*2; 
			}
			for ( int i = 0; i < arrNum_2.Length; i++ ) {
				Console.Write(arrNum_2[i] +" ");
            }
            Console.WriteLine();
            Console.WriteLine();
			//3
			Random random = new Random();
			int[] arrNum_3 = new int[10];
			for ( int i = 0; i < arrNum_3.Length; i++ ) {
				arrNum_3[i] = random.Next(0 , 100);
			}
			for ( int i = 0; i <arrNum_3.Length; i++ ) {
				Console.Write(arrNum_3[i] + " ");
			}
            Console.WriteLine();
            Console.WriteLine();
            //4
            int[] arrNum_4 = new int[10];
            int sums = 0;
            for ( int i = 0; i < arrNum_4.Length; i++ ) {
                arrNum_4[i] = random.Next(1,100);
            }
            for (int i = 0; i < arrNum_4.Length; i++)
            {
                Console.Write(arrNum_4[i]+" ");
            }
            for (int i = 0; i < arrNum_4.Length; i++)
            {
                for ( int j = 0; j <arrNum_4.Length-1; j++ ) {
                    if ( arrNum_4[j] > arrNum_4[j+1] ) {
                        int tempss = arrNum_4[j];
                        arrNum_4[j] = arrNum_4[j+1];
                        arrNum_4[j +1] = tempss;
                    }
                }
            }
            Console.WriteLine();
            for ( int i = 0; i < arrNum_4.Length; i++ ) {
				Console.Write(arrNum_4[i] + " ");
			}
            Console.WriteLine();
            for (int i = 0; i < arrNum_4.Length; i++)
            {
                sums += arrNum_4[i];
            }
            Console.WriteLine("最大值为：" + arrNum_4[arrNum_4.Length - 1] + "，最小值为：" + arrNum_4[0] +"，总和为："+sums+"，平均值为："+sums/arrNum_4.Length+"。");
            Console.WriteLine();
            Console.WriteLine();
            //5
            //反转数组
            int[] arrFomer = new int[]{1,2,3,4,5,6,7,8,9};
			//int[] arrNow = new int[arrFomer.Length];
			//int temp =arrFomer.Length-1;
			//for ( int i = 0; i <arrNow.Length; i++ ) {
			//	arrNow[i] = arrFomer[temp];
			//	temp--;
			//}
			//for( int i = 0;i < arrNow.Length; i++ ) {
			//	Console.Write(arrNow[i] +" ");
			//}
			int arrLength = arrFomer.Length-1;
			int temp;
			for ( int i = 0; i < arrFomer.Length; i++ ) {
				Console.Write(arrFomer[i] + " ");
			}
            Console.WriteLine();
            for (int i = 0; i < arrFomer.Length/2; i++)
            {
				temp = arrFomer[i];
				arrFomer[i] = arrFomer[arrLength];
				arrFomer[arrLength] = temp;
				arrLength--;
            }
			for ( int i = 0; i < arrFomer.Length; i++ ) {
				Console.Write(arrFomer[i] + " ");
			}
			Console.WriteLine();
            Console.WriteLine();
			//6
			int[] arrManage = new int[]{1,0,-1,3,0,-79};
			for ( int i = 0; i < arrManage.Length; i++ ) {
				Console.Write(arrManage[i] + " ");
			}
            Console.WriteLine();
            for ( int i = 0; i < arrManage.Length; i++ ) {
				if ( arrManage[i] > 0 ) {
					arrManage[i]++;
				} else if ( arrManage[i] < 0 ) { arrManage[i]--; }
			}
			for ( int i = 0; i < arrManage.Length; i++ ) {
				Console.Write(arrManage[i] + " ");
			}
            Console.WriteLine();
            Console.WriteLine();
            //7
            int[] MathsGrade = new int[10];
			int sum = 0;
			for ( int i = 0; i < MathsGrade.Length; i++ ) {
				Console.Write("请输入第"+(i+1)+"名同学的成绩:");
                Console.WriteLine();
                MathsGrade[i] = int.Parse(Console.ReadLine());
			}
            for (int i = 0; i < MathsGrade.Length; i++)
            {
                for ( int j = 0; j < MathsGrade.Length-1; j++ ) {
                    if ( MathsGrade[j] > MathsGrade[j+1] ) {
                        int tempsss = MathsGrade[j];
                        MathsGrade[j] = MathsGrade[j+1];
                        MathsGrade[j+1] = tempsss;
                    }
                }
            }
            for ( int i = 0; i < MathsGrade.Length; i++ ) {
				sum += MathsGrade[i];
            }
            Console.WriteLine("最大值为：" + MathsGrade[MathsGrade.Length - 1] + "，最小值为：" + MathsGrade[0] +"，总和为："+sum+"，平均值为："+sum/MathsGrade.Length+"。");
			Console.WriteLine();
            //8
            string[] strings = new string[25];
			for ( int i = 0; i < strings.Length; i++ ) {
				if ( i % 2 == 0 ) {
					strings[i] = "■";
				} else {
					strings[i] = "□";
				}
			}
			for ( int i = 0; i < strings.Length; i++ ) {
				if ( i % 5 == 0 && i!=0) {
                    Console.WriteLine();
                }
				Console.Write(strings[i]);
            }
            #endregion

            #endregion


            #region 二维数组

            #region 二维数组概念
            //同一变量类型的 行列数据集合
            //两个下标分别为行标和列标
            //比如矩阵
            //1 2 3
            //4 5 6
            #endregion

            #region 二维数组声明
            //和一维数组的声明相同
            int[,] arrAy = new int[10,10];
            #endregion

            #region 二维数组的使用
            //1.数组的长度
            //arrAy.Length;           数组的总长度
            //arrAy.GetLength(0);     数组的第一个维度（有多少行）
            //arrAy.GetLength(1);     数组的第二个维度（有多少列）


			//2.获取数组中的元素


			//3.修改数组中的元素





			//4.遍历数组




			//5.增加数组的元素
			//多加一列呢？



			//6.删除数组中的元素
			//套路同增加元素。
			//数组初始化之后 是不能够 直接删除元素 所以 如果需要删除元素 就要声明新的数组进行搬家
			//如果需要删除数组的中间的一个值呢？



			//7.查找数组中的元素
			//当数组中的元素个数较多时怎么去查找？

			#endregion

			#region 二维数组练习题
			Console.WriteLine();
            //1
            int[,] Tarr = new int[10,10];

            int ii=1;
            for ( int j = 0; j < Tarr.GetLength(0); j++ ) {
                for ( int k = 0; k < Tarr.GetLength(1); k++,ii++ ) {
                    Tarr[j , k] = ii;
                }
            }
            
            for ( int i = 0; i < Tarr.GetLength(0); i++ ) {
                for ( int j = 0; j < Tarr.GetLength(1); j++ ) {
                    Console.Write(Tarr[i,j]+"\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //2
            //0，1行  3，4列 改变值为0
            int[,] Num = new int[4,4];
            for ( int i = 0; i < Num.GetLength(0); i++ ) {
                for ( int j = 0; j < Num.GetLength(1); j++ ) {
                    Num[i , j] = random.Next(1,100);
                }
            }
            for ( int i = 0; i < Num.GetLength(0)/2; i++ ) {
                for ( int j = 2; j < Num.GetLength(1); j++ ) {
                    Num[i , j] = 0;
                }
            }
            for ( int i = 0; i < Num.GetLength(0); i++ ) {
                for ( int j = 0; j < Num.GetLength(1); j++ ) {
                    Console.Write(Num[i,j] +"\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //3
            int[,] Num_1 = new int[3,3];
            int sumss=0;
            for ( int i = 0; i < Num_1.GetLength(0); i++ ) {
                for ( int j = 0; j < Num_1.GetLength(1); j++ ) { 
                    Num_1[i , j] = random.Next(1,10);
                }
            }
            for ( int i = 0; i < Num_1.GetLength(0); i++ ) {
                for ( int j = 0; j < Num_1.GetLength(1); j++ ) {
                    if ( ( i == 0 && j == Num_1.GetLength(1) - 1 ) || ( i == ( Num_1.GetLength(0) - 1 ) && j == 0 ) || i == j ) {
                        sumss += Num_1[i , j];
                    } 
                }
            }
            for ( int i = 0; i < Num_1.GetLength(0); i++ ) {
                for ( int j = 0; j < Num_1.GetLength(1); j++ ) {
                    Console.Write(Num_1[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("对角线的和为："+sumss);
            /*0,0 0,1 0,2
            1,0 1,1 1,2
            2,0 2,1 2,2*/
            //4
            Console.WriteLine();
            int[,] Num_2 =new int[5,5];
            int tempsssss = 0;
            for ( int i = 0; i < Num_2.GetLength(0); i++ ) {
                for ( int j = 0; j < Num_2.GetLength(1); j++ ) {
                    Num_2[i , j] = random.Next(1 , 500);
                }
            }
			for ( int i = 0; i < Num_2.GetLength(0); i++ ) {
				for ( int j = 0; j < Num_2.GetLength(1); j++ ) {
					Console.Write(Num_2[i , j] + "\t");
				}
				Console.WriteLine();
			}
            Console.WriteLine() ;
			for ( int i = 0; i < Num_2.GetLength(0); i++ ) {
                for ( int j = 0; j < Num_2.GetLength(1)-1; j++ ) {
                    if ( Num_2[i , j] > Num_2[i , j + 1] ) {
                        tempsssss = Num_2[i , j];
                        Num_2[i , j] = Num_2[i,j+1];
                        Num_2[i,j+1] = tempsssss;
                    }
                }
            }
			for ( int i = 0; i < Num_2.GetLength(0); i++ ) {
				for ( int j = 0; j < Num_2.GetLength(1); j++ ) {
					Console.Write(Num_2[i , j] + "\t");
				}
				Console.WriteLine();
			}
            Console.WriteLine();
            //Console.WriteLine(tempsssss);

            //5
            int[,] num = new int[5,5];
            int x=0,y=0;
            for ( int i = 0; i < num.GetLength(0); i++ ) {
                for ( int j = 0; j < num.GetLength(1); j++ ) {
                    //num[i , j] = random.Next(0,2);
                    num[2 , 1] = 1;
                    num[3 , 2] = 1;
                    num[3 , 3] = 1;
                }
            }
			for ( int i = 0; i < num.GetLength(0); i++ ) {
				for ( int j = 0; j < num.GetLength(1); j++ ) {
                    Console.Write(num[i,j]+"\t");
                }
                Console.WriteLine();
            }
			for ( int i = 0; i < num.GetLength(0); i++ ) {
				for ( int j = 0; j < num.GetLength(1); j++ ) {
                    if ( num[i,j]==1 ) {
                        x=i; y=j;
						for ( int k = 0; k < num.GetLength(1); k++ ) {
							num[x , k] = 1;
						}
						for ( int z = 0; z < num.GetLength(0); z++ ) {
							num[z , y] = 1;
						}
                        
					}
                }
			}
            
            Console.WriteLine();
            for ( int i = 0; i < num.GetLength(0); i++ ) {
				for ( int j = 0; j < num.GetLength(1); j++ ) {
					Console.Write(num[i , j] + "\t");
				}
				Console.WriteLine();
			}

            #endregion

            #endregion

            #region 交错数组
            #region 二层交叉数组
            //数组的数组
            int[] ints = { 5,6,7,8,9};
            int[][] arrAy1 = new int[][]{
             new int[]{ 1,2,3,4},
             ints
            };


            //遍历
            //arrAy1.Length       表示arrAy1中的一维数组的个数
            //arrAy1[i].Length    表示arrAy1中某个一维数组的长度
            for ( int i = 0; i < arrAy1.Length; i++ ) {
                for ( int j = 0; j < arrAy1[i].Length; j++ ) {
                    Console.Write(arrAy1[i][j] + " ");
                }
                Console.WriteLine();
            }
            #endregion
            #region 三层交叉数组
            //存放的值为数组的数组
            int[][][] arr3D = new int[][][]{
                new int[][]{ 
                    new int[]{ 7,6,5,4,3,2,1} ,
                    new int[]{ 1,2,3,5,4},
                    new int[]{ 1,3,6,4},
                },
                arrAy1,
            };

			//遍历
			//arr3D.Length          表示arr3D中的二层交叉数组的个数
			//arr3D[i].Length       表示arr3D中的某个二层交叉数组中的一维数组的个数
            //arr3D[i][j].Length    表示arr3D中的某个二层交叉数组中的某个一维数组的长度
			for ( int i = 0;i < arr3D.Length; i++ ) {
                for( int j = 0;j < arr3D[i].Length; j++ ) {
                    for(int k = 0; k < arr3D[i][j].Length; k++ ) {
                        Console.Write(arr3D[i][j][k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            #endregion
            #endregion

            #endregion


            #region 选择排序基本原理
            //新建中间商（记录最大值的索引值）
            //依次比较
            //找出极值
            //放入目标位值
            //比较N轮








            #endregion

            #region 选择排序代码实现
            Console.WriteLine("-------------------------------------------------");
            int[] array1 = new int[]{ 5,3,7,9,1,8};
			for ( int i = 0; i < array1.Length; i++ ) {
				Console.Write(array1[i] + " ");
			}
            Console.WriteLine();
            

            //遍历比较
            for ( int n = 0; n < array1.Length; n++ ) {
				//声明中间商记录极值的索引值
				int index = 0;
				for ( int i = 0; i < array1.Length - n; i++ ) {

					if ( array1[index] < array1[i] ) {
						index = i;
					}
				}
                if ( array1.Length - 1 - n != index ) {
                    int tempa = array1[array1.Length-1-n];
					array1[array1.Length - 1 - n] = array1[index];
                    array1[index] = tempa;
				}

			}
            for ( int i = 0; i < array1.Length; i++ ) {
                Console.Write(array1[i] +" ");
            }

            #endregion
            Console.WriteLine();
            int[] a = new int[]{ 10};
            int [] b = a;
            b=  new int[5];
            Console.WriteLine(a[0]);
        }
	}
}
