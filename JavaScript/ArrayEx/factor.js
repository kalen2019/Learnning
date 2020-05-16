var a = 45;
function factor(a)
{
    var factor = [];
    for(i=1;i<10;i++)
    {
        for(j=2;j<10000;j++)
        {
            if(a%j == 0)
            {
                factor.push(j);
                a = a / j;
                break;
            }
        }
    
    }
    return factor;
}
console.log("factor(",a,")=>",factor(a));