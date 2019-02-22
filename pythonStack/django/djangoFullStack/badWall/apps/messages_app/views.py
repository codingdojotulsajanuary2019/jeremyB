from django.shortcuts import render, redirect
from django.core.urlresolvers import reverse
from apps.login_app.models import User

# Create your views here.
def wall(request):
    context = {
        "user_info": User.objects.get(id=request.session['id'])
    }
    return render(request, "messages_app/wall.html", context)
