var a = [1,2,3,4,5];
function mean(a)
{
    var i=0;
    var j=0;
    for(i=0;i<a.length;i++)
    {
        j += a[i];
    }
    var mean = j/a.length;
    return mean;
}
console.log("mean(",a,") => ",mean(a));