from django.shortcuts import render, redirect
from .models import User
from datetime import datetime, timedelta
from django.contrib import messages
import bcrypt
from django.core.urlresolvers import reverse

def index(request):
    return render(request, "login_app/index.html")


def registration(request):
    print("*"*90)
    print("Register new user")
    errors = User.objects.register_validator(request.POST)
    print(errors)
    if len(errors) > 0:
        for key, value in errors.items():
            messages.error(request, value, extra_tags=key)
        return redirect('/')
    else:
        pw_hash = bcrypt.hashpw(request.POST['pword'].encode(), bcrypt.gensalt())
        new_user = User.objects.create(fname=request.POST['fname'], lname=request.POST['lname'], email=request.POST['email'], password=pw_hash)
        print("User Added")
        request.session['id'] = new_user.id
        
        return redirect(reverse("trip:trips"))

def login(request):
    print("*"*90)
    print("Login")
    errors = User.objects.login_validator(request.POST)
    print(errors)
    if len(errors) > 0:
        for key, value in errors.items():
            messages.error(request, value, extra_tags=key)
        return redirect('/')
    else:
        user_info = User.objects.get(email=request.POST['login_email'])
        request.session['id'] = user_info.id
        return redirect(reverse("trip:trips"))

def logout(request):
    request.session.clear()
    return redirect('/')