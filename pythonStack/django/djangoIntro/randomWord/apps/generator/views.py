from django.shortcuts import render, redirect
from django.utils.crypto import get_random_string

# Create your views here.
def index(request):
    request.session['word'] = get_random_string(length=14)
    if 'count' in request.session:
        request.session['count'] += 1
    else:
       request.session['count'] = 1 

    # if request.method == "POST":
    #     return render(request, "generator/index.html")
        
    return render(request, "generator/index.html")

def reset(request):
    del request.session['count']
    return redirect('/')