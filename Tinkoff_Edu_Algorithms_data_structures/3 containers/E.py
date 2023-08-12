class Heap():
    def __init__(self):
        self.heap=[-1]

    def Insert(self,x,index):
        i=-1
        while self.heap[i] >= x:
            i-=1
        self.heap.append(x)
        return index+i

heap = Heap()

n = int(input())
a = input().split()
sums=[0]
ans=[]
for i in range(n):
    sums.append(int(sums[-1])+int(a[i]))
    min_ind = heap.Insert(int(a[i]),i)
    ans.append([(sums[i+1]-sums[min_ind+1])*int(a[i]),i-min_ind])


for i in range(1,n):
    ind=i-ans[i][1]
    if ind>=0:
        if int(a[i])!=0 and int(a[ind])!=0:
            s=(ans[i][0]/int(a[i])+(ans[ind][0]/int(a[ind])))*min(int(a[i]),int(a[ind]))
            if s > ans[i][0]:
                ans[i][0]=s

maxx=0
for i in range(n):
    if maxx<ans[i][0]:
        maxx=ans[i][0]
print(int(maxx))
#print(ans)