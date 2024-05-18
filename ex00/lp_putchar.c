#include <unistd.h>

void lp_putchar(char c){
write(1,&c,1);
}
