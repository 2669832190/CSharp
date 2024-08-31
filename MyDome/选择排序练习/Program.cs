namespace 选择排序练习 {
	internal class Program {
		static void Main ( string[] args ) {
			#region 冒泡排序和选择排序注意事项

			//冒泡排序需要注意内循环的范围
			//范围为长度-1
			//0，1，2，3，4，5，6，7，8
			//1，2，3，4，5，6，7，8，9


			//选择排序时需要注意第二个循环内的两个判断语句的条件
			//
			//第一个判断语句的条件为 当 接收最大值的索引值 的对应数组值 小于 循环的数组中的值 的 时候 需要改变最大值的索引值
			//同时需要注意内循环的循环数初始值从1开始，到数组的长度-外循环循环数变量
			//
			//第二个判断语句是为了  判断最大值的索引对应的数组值  是否和  需要换位置的数相同，如果 不相同 才需要换位置，相同 则不需要换位置
			//需要注意的是 需要换位置的数组数的下标索引值  应该为 长度-1-外循环的循环数变量
			#endregion

			int[] ints = {3256,23,6467,34,23,65,89,5,32,221343,56,78,67,34,12,6};
			/*	冒泡排序
             * for (int i = 0; i < ints.Length; i++)
            {
                for (int j = 0;j < ints.Length-1;j++)
                {   
					if (ints[j] > ints[j + 1] ) {
						int temp = ints[j];
						ints[j] = ints[j + 1];
						ints[j + 1] = temp;
					}
                }
            }*/

			/*	选择排序
			 * 
			for ( int i = 0; i < ints.Length; i++ ) {
				int indexx = 0;
				for ( int j = 1; j < ints.Length - i; j++ ) {
					if ( ints[indexx] < ints[j] ) {
						indexx = j;
					}
					if ( ints[indexx] != ints[ints.Length - i - 1] ) {
						int tempp = ints[indexx];
						ints[indexx] = ints[ints.Length - i - 1];
						ints[ints.Length - i - 1] = tempp;
					}
				}
			}*/
			for ( int i = 0;i < ints.Length; i++ ) { Console.Write(ints[i] +" "); }
			//-----------------------------------------------------------------------------------------------------------------
			//-----------------------------------------------------------------------------------------------------------------
			/*int[] array = new int[] { 324,46,4789,4,532,12456,7,34232,4212456,5,568,32442,4456,546,234,56 };
			for ( int i = 0; i < array.Length; i++ ) { 
				int indexs= 0;
				for ( int j = 1; j < array.Length - i; j++ ) {
					if ( array[indexs] < array[j] ) {
						indexs = j;
					}
					if ( array[indexs] != array[array.Length - 1 - i] ) {
						int temps = array[indexs];
						array[indexs] = array[array.Length - 1 - i];
						array[array.Length - 1 - i] = temps;
					}
				}
			}
			for ( int i = 0; i < array.Length; i++ ) {
				Console.Write(array[i] +" ");
            }*/
			//-----------------------------------------------------------------------------------------------------------------
			//-----------------------------------------------------------------------------------------------------------------
			/*int[] arr = new int[] { 4,24,3,6,345,4353,4325,2,214,23,7,243,786546,342,834209 };
			for ( int i = 0; i < arr.Length; i++ ) {
				int index = 0;
				for ( int j = 1; j < arr.Length - i; j++ ) {
					if ( arr[index] < arr[j] ) { 
						index = j; 
					}
					if ( arr[index] != arr[arr.Length - 1 - i] ) {
						int temp = arr[index];
						arr[index] = arr[arr.Length - 1 - i];
						arr[arr.Length - 1 -i] = temp;
					}
				}
			}
			for ( int i = 0;i < arr.Length; i++ ) {
				Console.Write(arr[i] +" ");
            }*/
			//-----------------------------------------------------------------------------------------------------------------
			//-----------------------------------------------------------------------------------------------------------------
			//Console.WriteLine("Hello, World!");
			//int[] n = new int[]{ 234,657,3,23,65,4534,123,57,8,987,45,4,2424};
			//定义一个变量接收最大值的索引
			//循环遍历比较大小，得到最大值的索引值
			//交换最大值的位置
			//循环n轮

			//循环n轮
			//for ( int k = 0; k < n.Length; k++ ) {
			//定义一个变量接收最大值的索引
			//int index = 0;

			//通过循环遍历数组比较大小
			//for ( int i = 1; i < n.Length-k; i++ ) {
			//当满足有数组值大于第一个值时对索引进行记录
			//if ( n[index] < n[i] ) {
			//index = i;
			//}
			//进行判断最大值的所对应的位置的值是否相同，不同时再进行数值的换位
			//n.Length - k - 1		数组的长度-1-k 得到的是 每次循环轮数需要换位的数组的索引值		
			//因为每次循环都会确定一个最大值（放在数组的最后一个索引值），
			//从而已经确定的索引值就不需要进行换位，
			//因此只需要将已经确定的最大值的数目（即最外层循环的k）减去再减去1即可得到每次没确定最大值的最后一位的索引值
			//if ( n[index] != n[n.Length - k - 1] ) {
			//int temp = n[index];
			//n[index] = n[n.Length - k - i];
			//n[n.Length - k - 1] = temp;
			//}
			//}
			//}

			/*for ( int i = 0; i < n.Length; i++ ) {
				Console.Write(n[i] + " ");
			}*/


			/*for ( int i = 0; i < n.Length; i++ ) {
				int indexx = 0;
				for ( int j = 0; j < n.Length - i; j++ ) {
					if ( n[indexx] < n[j] ) {
						indexx = j;
					}
					if ( indexx != n.Length - i ) {
						int temps = n[indexx];
						n[indexx] = n[j];
						n[j] = temps;
					}
				}
				
			}*/

		}
	}
}
