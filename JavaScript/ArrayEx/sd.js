var a = [1,2,3,4,5];
function sd(a)
{
    var j=0;
    for(i=0;i<a.length;i++)
    {
        j += a[i];
    }
    var mean = j/a.length;
    var k = 0;
    for(i=0;i<a.length;i++)
    {
        k += ((mean-a[i])*(mean-a[i]));   
    }
    var sd = Math.floor(Math.sqrt(k/a.length)*1000)/1000;
    return sd;
} 
console.log("sd(",a,")=",sd(a));