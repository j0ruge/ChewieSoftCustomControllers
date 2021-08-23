using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace VDRDataAnalyzer
{
    public class Cripto
    {
        private const String RSAKey = "<RSAKeyValue><Modulus>vUDdzmbSAMGfpgWJ1lProUyuxZmqqROPJLjVKjDym+zfwDS/r/MspMYQscC1H+FKbvQkEi3l8RGOKAoPlopwUVba9DDJ9oRAKMQ1qDTJTxkWMuJlrcx+z4TSZXxXTaQ/1FLgDBraqtg1bUzDib1saSEQ7+A/bT9Lr7VHBFios6Ezm/jaipRKCqAz2tYnZYF4OwmH9ZTinjqvOFGH3CWt0eZx6k+wMTIQnYEC9nHIgnn6JqBxGsjKHZ3bqeUtGpQO677ftKHODj1DIV0dHdWpkTi1VwUH3H471DA3At2Ur2kSA5YKguQO2594qN6VEAl77PlxIaIzXprNcJz/mSWANEsxNXWahZtIxgAXVrF90UlgA8wMtD7dvoSJfmA5mtBwPL6BxhNxlKAe5OegrILgnxHSN5HR2lRBvJsnx/TIneuREyl9J49eGF2jFMV8R0czqostvvgPIHDyxOUe69hRj0BIpQzS6AR4yrfINyHDNQLk9kB76pfmQZO0GhefA1LfbaUd/c892Ry90TAaukXdDoLketfO3rpPuKV3g/JFGHcbrJdr225oqjRbIEVJ0QxxtComlwAgeiNp0V4B7VwcJU+tSyPyVW/QkO92J7geGO3bqQgVUD45rd++AkbBvy9KhBNQ4zn2zjMppwLfqIGnA1m2rKMZyMsmD6t8hff0sEkjECtnqrZQy0wA+YUenHiP60H7HdsuuyjGe5np0H0O60lC2Fx4EWDD6HF/jb8MD8VychEFo1EH+nHTiU8LtF5LBeGeAVH7c2UUiAg63C7rewP6BSokO4aJqCDlnLCWuBNZNFBNx0St1G1u5ayRqcWeDuDzREgCvqGF7N06h7Vhdi/omfi4Ry3U4VPAdHf3KjPPd9kG+29V1m14w04+UBW67Ne3gva4zuOYI+McDRJIY4avVgHpr//ajkOcOOjQQPjj1g6pHVCcapXuW5xFtZ05awldJkuOhXfzbZDngBky228inqBjkDRsEtN8wJBWlAOcxjznccRLb8kgCka2R3xDx3lVQ0SMxshICPccVysSClIskQ6YuUz135D26CjSvn5AsoNX0S8c+SM9rqjQJx2avkZJflEBnuRBsl0plCAykd1VMVIIO5CjD0AywnGIZY4ysASsEolEZk4PxAgy4nYUC126xC++mLBMdUTzig0pkzTxeJXtco2NnDTL5pn49svZ+C3WES9mj6dGBor9inLRaUihKdxeTkCx2BfqeXCt3QG2gTW2iUX64CGjxxRmQy6yooUGgcFmmr819Ub7vI+y4nSqkt7Y834ktpHk7pUsRGNH+uZ3S8PTEKF9F/l4T+y0cPUgti87bFncqMYt3Pu1rQz+pe9x2Ke8qgjqMecw3mpa/FAZS7i/PfXwuSxS35ln/qIhY3NzTde24177QbjODlZgWBksjG6GqGvSYvNuJdX1sXtSx8kGPmWPHfSXjRu5x/R8nkilBgEqo8BUHQs+sGi4sTK/sc4KNMCM9EE9dwKduTozTGVnDTo1</Modulus><Exponent>AQAB</Exponent><P>DvpE9CQA+D9lcGxSz8s0UbZZfgxNVD9T4ebFnRmncv6kIg6KJD1BjfAYmJ5rp+SHWOnuYtQrVOW0QAaUDvpfFVaabvuScrTfrVN4J7NYFe6PtNxzTKTQdm9Ys5wis9WU9M9W78F6UId3zwQfZCyfBbHGv8BvZoxarJw8vbVnKZlLb0f9yvQWK5t1Tu1jHIP6XnW/6T3GQqTW6y1Bc9W+5iE3rUMU72oMr0SeeWJrailXq3EV/YLrzctgQiTO4IWXPxUlkXlidTBmGmxbj4GDmCm5wwQeD+f+mReVO7D41D9PNJLtMG5rN5nXH4JD25Uf4rlV78j4Kqkaxm5NdNF9xdj69x1KJBMMCMMo2K9mPLYJFhySLu6R4BXJ9B3aCwmPpS+9T86R+xiT5IMiyzymLgIwE1ZFH3rIcr8Jp/fx/tgwhiVVp3bW/yNx5C86nCqYW3JCOShFIyEIgiogo4DC1X6tanWxeceT45xLm3GxvC+OCD2aqi4EVQqsyXwp4rHqBGdKJt+g10alNeqh2Q+nEv+f48kgHMOAtjNUKuNMwiAFHMu3Kc8qq68Rc3SHS5p6hKTs4RYY2q+L2zGDwygJ55km78RryRNY2DAnRxfXPKeZgYIePU9BJmp0JnLzIKMtVNa5y4GAtKcF6JOEeRWp89+iNaJZjz/AcH250ygPA4LYwG8Sh3XugLIVj3HX/T6abAyxe4PVx2m3XBNAaj2A0tOCIqyIQa9K6mNigPzkVoQ7RlN93Ss=</P><Q>DKLAeBRVp+zWR9jHXG2zyp+3Q1JObgo0q5r2CiAjVFESolklfM5WeZAlMJApGLP5czHiAZPpPGmEiL/tsbrvzOUYpGE8l1Pbn4uk1/mZWTMwiL+1BCpckp0YrecP0W7ORcAbcUASSpaGZ1Hit4Zt0S9GmtTPCFi0NF2Q1baXw5fiTl630jyJgdgcsyN/DMTtt2feoc7Jg7fcts0+w/iAzfij63Y+5EPbWCK3GWfHfj0reFfFUrCXNKVS7DjPTTfo0tNkK/7nnpDv2Fn1zQnT1M5TnUN7i8F9H+TMriSnFYBsENh744ypSOMnKvqedQu8U/tqeauFSv0f3iJs2XJPHPP9teDlA0eq6dBZC9i7RFdmBmklFTYmE/LaKvvqqvEKY1aVK66v6UH6ft4HqkSxJQBrns+/2qnUW7d1QWF4ywVlTYbWFXuS1wE+6kqeqj8pZWrX3newMlLXYqA3AE3Oj/tqBdkSblHHlnbaDfeaLzsDavuDgcvkBewU9rWzC+tb8BipvbMo3b5Iyd3Ga+xJ/EU4lMk8v6PI/EADYuW0gGa+rY6gQgw7Ye0w9kmu8Zq+pSwBeCTjycR+h65ntx9KzfeaSK9t7IPZRrJT//GzTTe9oEoTEeYGb2Pk30Oz2haB8jCDD7nS4RAgkf9RzptryM3dwjcslvJNEphfl19Ir21gBjx3CNZZkvq5KaXBpvmk6/0l/2mZ+PwtcOYFX4aMANoE3Q7Loh8P5EheaxkB0WvYsrQJVh8=</Q><DP>ClqldIm3Sea5v6CDFzeJMbv33hWvF8C3woGAt3xWsD6tRQX8JdVbDj6fIlLSZbysfKErtZKragNqOqDRlhErzlqSZIrx0O6NewsrE3b+PBsxqXyFEMUXf+i1z2Tu8JeEZEE5/oEoh6c/AhP9h4j5XjxqA4GLAb+hp5ZSv2s6qB1bctC3+KgI85iC3k9ppvruCIMqapnUB5phIS+mAegQEpOAI/0t6dzMbBXp4ExTqY5vFwwUga8SSLCCGPfNNJXl2yxJTmo10IHm8/lYyrpkOLsPumuMRL7C2R7egedz/XbO0K+J3WNYJ5Xoi9XIB3LuGhS5/gxW01cYNXlnfoycgDviMxdCe/HW7e/Muw92hB3r5idWP6+ZlOo7NNG2PM8dSLraCuPpM0boZp7pXMrOrxvAFH4dRwfgrsK2cDIOT3kxAmuo7R5QvwzH3VFxGSixLvasJUtbkE9zzFhHPAD1sBXk2KYITQHVkRIpiopsroXJkJTV6TPqtsesb5WwdxE7kFO/hWQvkuM5ry5HOQGDJLUm2Zfe5UOaJVsSopuEIudz4VZLh1G6U/mw/LngFjny3OQPBgP6pqOY8a0nQ7DYOA0+R57oTJddYgbYAGPQ3hOXIVrMgOHbTi1lonbw8O0dl3rh8nfSfBDDGudwOyzo0rkVMDLN6yPNa3bfEcStrGW2ZkHi81ZpzPpPwVyYTnAK3QthXtvi2/qPUc3VSBzAg/7IBiR0BcSi66pNHJK3X8AGIjXx2wU=</DP><DQ>Cj6RqUljQOhluo5o4+kVUXw4St6aM+EWXuMeA4uW2S952iJIoG1x8tEJNdxLVXnlDp4szHatLIuoJm7lOamD7iz30536T/5vG2VOWsREreswuE4lZqEpuLyhW6zwSC58ElT0atc1fT+Y7H+ZPo5Azs5zgehziiLQx3vshzioxq2Hj15/znXCToF2k05+HU40JPSTrcBH5QDWc2boMl5xn4ys6aROzSau2UAcDv7y4MibS9BtbOM7VDWNi3NrrwFbREKa/oiGJSsBKfmVrY0AL5Kwe9pQejh/R7Jqt+2DgY1DEE1T9GMAhNWV1eSnP+Ip6DT4WHjVcrzSb3ido5ZnyeOPmTwisIwUZ8jByTcIbRom35+zrwTdzmKguyTPV5RhhbSW8HmKqaUSgHVm5YcX0BYNKw7oT1JNl6af7EgodQGE5lwhif1MSgD6j128Ue8vksgTCI0lT0eW1KFstlRe2qFNjjw2Ezc+iCEIHTbXzN8doEkWj89MqfiD7pnV9h31xi1YwTJWOaGixfeGfc1vFpbQjuCw3fbeZpVHqZDuzQOAKJpwF9xu8LAreCK5MazyUFvjPRM7k0Q6Cas+71rxfRf4AGIqzwz+xbCjJelCI6LDnQcxettx8DGfR9xOHs0MwdzPBZr0+//lSDkmjEm6E23FE0dEYYVFM4RSTBm2hnQ43BV9tK6EpQOdx8RZwxS3v5TYj8GAUjuyY8w6Iv6k17PrKYZrVp+0dLKvykjWDoJPiGMrBqU=</DQ><InverseQ>A+L49lZaEn7Mm2LKyntGoajTP60fxLXfsOCGCcLUijvftu1SDt28klSnakV32LePGqgFKuAQliE9VwOGVVZ1Onkz3vK3LSMpYHN7vrJ8wLYsSXYVoC2jdaCuwiBN7pJP3lPVl6E6hVotNvmKCc9Ghjn91gextiGnDgQW4egrorFjJPW1aUpJ8uSl1PO2WLE7bickMJ0X3VDaBDj51jlIl3lCuQfUph2HIsuW1jg8eGEL/2hlR79Jd5LrESMDRrYyBTjjMbL5f3u26yGVv8dFucFWebGIS0KEUqhXrhkxSdgw6MKGuXQ7TaUNyfa2GWCOIU8AC4ZDZSYPpsyvAPfPUhhBrhXWAELzXftyGxUuEZUFi0GxQ9AJn7Q/MxUC03KF1ztWXVfmhKZwdSmDvbPPaHH95/J22EV2FMLKULmyxWTmV20CUWGX7Dcr4uOO8NquIyqApuj7IQIAEisIeROWnhyS/w0CUlTyRLqImf8amQ+RC7WPepSef33YPRQEIiQVY3gR08zh4OMKf/okdra9ZtUDNMamv3eR13Ws3q1y4EuQwmpcDOdf3q7vSrgoz1yLVAw0yPiFlg8l7OuODPCO78kw8zko9ujTV0rBG5/l/UkvJcTx8/ZH752U2lIOImV3YbHZf2fPC4wrbV/5cbGEkfRWXEsinEWJVBr9Bc42Gbc/Dj6CPJ5zJc6yVXABvBo0iJErZOTW2Fv6C9jr/KKSWZ9lkCIyUW/wg/ASfzbQN4SZlbyneig=</InverseQ><D>Lm9L/OidfjIDyehx+XR9zAXUnAcoKHP0Gz5+juuTm05zV+WZYsJ3obY3QmXWCwxsBu1ALHW2hX+ZMZnGWVl+VXbKIkAWTbYFR/tcbvkEq7OsDrAd4pbaRnCAbwYjJZm3T5FGB7JPFLwX38mF8LXZc7H5ReHvrg5ps6L22conGmvjDdHxTS81O4YzMu54nB84MMQV59uv/sLHWzol644TJ/0y1hrXUDrIeNy+rVkdqWXkSrXzCm9ZqAqjavwgJPVO8+jRWrCYrkW5wuXlzvwtrsQLOl6xnxgZ9eYemUVkxeUx1k9qJNNwEdL+9/AlAtpQ3cQWTfpOQFgbMBZVYG4jFrGcUVGZqE6BfJNpJoxGIqOuO0BFnbQPFD/QvIE/oQyjfUQA82ix5ZWj/uYWNj2mf2EQAzJ0Gu2xc2VeTWFyF81Euz7ixmIW5EOVT/NkmtiNhLrBbqnOjFcqOcU94QAigtNy/4w181eli5esOFrAWrFrHECWJuk+RbjH598D1PzwdSaeRTgkJLE4oar749hgdL8I8FsjFuL/zH5M5ML80RPoZmCAxkZAyAIwmapmgjRbcakl7sbJMS6fOA+oyWRgQ4dZLaaUPwJAWk9m3jf+qn8x9jdVg2rBHDhZlpVl1FL2JZHXtujx9YX4IlJCLkYhhGDuwU0DdpDhtdaNpxE/qEFJqR39QZWaHUd4tcBD0oCCT2bRBnJQ9Pr8ODd7dvw4POKs1AlcLGdhqhavBUhq3TPE8NfcWj8xDw1hFv5xNlkF+t92/sh628jvShmfLLXeDGXlhG3bVveK/j3gcGRMb5TjAGNyRugua28LjSLzGmXvPWE70oo2XE91Jyw6e7zovplnCeM4W8N1J2/hY3WDgfWXYSs8A7xvMP0eAv3QYEY/rJiVP6Zwebv0SfhJxfSzI3ecfjFHVC6KKg4rOF2oUAWfnNga0vSm+8lvvWOu2B2dQmBIf6uJpGRxDP+wse8r0JxP1Z4/KIV8hpJf1gqK7K9l355Y3ES4n1kcv7vA/cKOVfyaTpOGmjc6ZBg8BjvntHplWqV/2FRhVNE1uKkE4TPSR7Mp0NFiQQjUpI25K5xHKNIiE3bG1EGa/wakyv/2lySkq8zKvH+A86WUjF5eikeIBbQ5Nyffe12fNO82lOpBmY1hCaTfOyPgqoywWOWZatFhbYE0IyQ4fC/r3QDvhHy2qN5/ZL3qXD3ysSZBsOdINLwML/x74jcfGETjOkbXj0TLLNgd66B6ieyM0WkOQuOqFNDi4RlVPntGrdoShHwrO++XGXylCjxDvF8bhOlcFkAL95SR38sGI+tU0SLdyzLm12FpFjPN/TyKboGX5mQ5jlVBRVy+LdHQO802ACxVj12LDi9k6O5glCoUs7oKqjpyuN8KQtrjaQeKCa2IWGbcgNSZi97GDXjQ4ifTPyNhdyqk2MKh7BTXzKbGz1NwRWZOBK8NF35RlQi625dgC8y7m32E6Q+qlXYpRGLlISFLPzIoAVHpzF5K0cfB</D></RSAKeyValue>";
        public string Criptografar(String Texto)
        {
            String TextoCriptografado = "";

            using (StringReader reader = new StringReader(Texto))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {

                var testData = Encoding.UTF8.GetBytes(line);
                using (var rsa = new RSACryptoServiceProvider(1024))
                {
                    try
                    {
                        // client encrypting data with public key issued by server
                        //
                        rsa.FromXmlString(RSAKey);

                        var encryptedData = rsa.Encrypt(testData, true);

                        var base64Encrypted = Convert.ToBase64String(encryptedData);
                        TextoCriptografado = TextoCriptografado + base64Encrypted.ToString() + "\n";
                    }
                    finally
                    {
                        rsa.PersistKeyInCsp = false;
                    }


                }
                }
            }
            return TextoCriptografado;
        }
        public string Descriptografar(String Texto)
        {
            String TextoDescriptografado = "";

            using (StringReader reader = new StringReader(Texto))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    using (var rsa = new RSACryptoServiceProvider(1024))
                    {

                        try
                        {
                            rsa.FromXmlString(RSAKey);
                            if (!String.IsNullOrEmpty(line))
                            {
                                var resultBytes = Convert.FromBase64String(line);
                                var decryptedBytes = rsa.Decrypt(resultBytes, true);
                                var decryptedData = Encoding.UTF8.GetString(decryptedBytes);
                                TextoDescriptografado = TextoDescriptografado + decryptedData.ToString();
                            }
                        }
                        finally
                        {
                            rsa.PersistKeyInCsp = false;
                        }

                    }
                }
            }
        
            return TextoDescriptografado;
        }
    }
}
