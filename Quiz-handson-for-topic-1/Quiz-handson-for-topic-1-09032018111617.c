#include <stdio.h>

int main()
{
 int rate;
 scanf("%d",&rate);
 if(rate < 300)
 {
  printf("We dont have any brand below 300");
 }
 else if(rate > 600)
 {
  printf("You just have Rs.600 with you");
 }
 else if((rate > 300) && (rate <= 449))
 {
  printf("Brand A");
 }
 else if ((rate >= 450) && (rate <= 579))
 {
  printf("Brand B");
 }
 else if ((rate>=580)&&(rate <= 600))
 {
  printf("Brand C");
 }
    return 0;
}
