using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Task description
A non-empty array A consisting of N integers is given. A pit in this array is any triplet of integers (P, Q, R) such that: 0 ≤ P < Q < R < N;
sequence [A[P], A[P+1], ..., A[Q]] is strictly decreasing, i.e. A[P] > A[P+1] > ... > A[Q];
sequence A[Q], A[Q+1], ..., A[R] is strictly increasing, i.e. A[Q] < A[Q+1] < ... < A[R].
The depth of a pit (P, Q, R) is the number min{A[P] − A[Q], A[R] − A[Q]}. 
For example, consider array A consisting of 10 elements such that:
A[0] =  0
 A[1] =  1
 A[2] =  3
 A[3] = -2
 A[4] =  0
 A[5] =  1
 A[6] =  0
 A[7] = -3
 A[8] =  2
 A[9] =  3
Triplet (2, 3, 4) is one of pits in this array, because sequence [A[2], A[3]] is strictly decreasing (3 > −2) and sequence [A[3], A[4]] is strictly increasing (−2 < 0). Its depth is min{A[2] − A[3], A[4] − A[3]} = 2. Triplet (2, 3, 5) is another pit with depth 3. Triplet (5, 7, :sunglasses: is yet another pit with depth 4. There is no pit in this array deeper (i.e. having depth greater) than 4.
Write a function:
class Solution { public int solution(int[] A); } that, given a non-empty array A consisting of N integers, returns the depth of the deepest pit in array A. The function should return −1 if there are no pits in array A.
For example, consider array A consisting of 10 elements such that:
A[0] =  0
 A[1] =  1
 A[2] =  3
 A[3] = -2
 A[4] =  0
 A[5] =  1
 A[6] =  0
 A[7] = -3
 A[8] =  2
 A[9] =  3
the function should return 4, as explained above.
Assume that:
N is an integer within the range [1..1,000,000]; 
each element of array A is an integer within the range [−100,000,000..100,000,000].
Complexity:
expected worst-case time complexity is O(N);
expected worst-case space complexity is O(N) (not counting the storage required for input arguments).
 */
namespace TaskForOpinov8 {
    class Program {
        /**   
         * <summary>
         * Fill with random numbers from -1000000 to 1000000
         * </summary>
         * <param name="lenght">Size of a masiv</param>
         * <returns>A full masiv</returns>
        */
        public static int[] A(int lenght) {
            int[] A = new int[lenght];
            Random rand = new Random();
            for (int i = 0; i < lenght; i++)
                A[i] = rand.Next(-1000000, 1000000);
            return A;
        }

        /**
         * <summary>
         * Find max the depth of pit in masiv A
         * </summary>
         * <param name="A">A masiv from outside</param>
         * <returns>A maximum the depth of pit, if not found return -1</returns>
         */
        public static int solution(int[] A) {
            int maxDepthOfPit = 0;
            int depthOfPit = 0;
            if (A.Length <= 2) return -1;
            for (int i = 1; i < A.Length; i++) {
                if (A[i - 1] > A[i]) {
                    depthOfPit++;
                }
                if (i != (A.Length - 1)) {
                    if (A[i] < A[i + 1]) {
                        depthOfPit++;
                    }
                    if (A[i - 1] < A[i] && A[i] > A[i + 1]) {
                        maxDepthOfPit = depthOfPit > maxDepthOfPit ? depthOfPit : maxDepthOfPit;
                        depthOfPit = 0;
                    }
                }
            }
            return maxDepthOfPit != 0 ? maxDepthOfPit : -1;
        }

        static void Main(string[] args) {
            int lenght = 1000000;
            Console.WriteLine(solution(A(lenght)));
            Console.Read();
        }
    }
}

