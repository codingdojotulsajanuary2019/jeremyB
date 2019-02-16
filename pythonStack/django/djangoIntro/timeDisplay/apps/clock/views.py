from django.shortcuts import render, HttpResponse
from time import gmtime, strftime, localtime

# Create your views here.
def index(request):
    info = {
        "time": strftime("%a, %d %b %Y %H:%M:%S", localtime())
    }
    display = info['time']
    print(info)
    print(display)
    return render(request, "clock/index.html", info)