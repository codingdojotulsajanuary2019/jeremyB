from django.shortcuts import render, redirect
from django.core.urlresolvers import reverse
from django.contrib import messages
from apps.login_app.models import User
from .models import Trip
from datetime import datetime, date

def trips(request):
    print("*"*50)
    print("got to trips")
    if 'id' in request.session:
        context = {
            'user_info': User.objects.get(id=request.session['id']),
            'my_trips': Trip.objects.filter(created_by=request.session['id']),
            'joined_trips': Trip.objects.filter(joined=request.session['id']),
            'other_trips': Trip.objects.exclude(joined=request.session['id']).exclude(created_by=request.session['id']),
        }
        return render(request, "tripTrack/trips.html", context)
    else:
        errors = {}
        errors['login'] = "You must login to view the site"
        for key, value in errors.items():
            messages.error(request, value, extra_tags=key)
        return redirect('/')

def new(request):
    print("*"*50)
    print("got to new")
    if 'id' in request.session:
        context = {
            'user_info': User.objects.get(id=request.session['id']),
        }
        return render(request, "tripTrack/new.html", context)
    else:
        errors = {}
        errors['login'] = "You must login to view the site"
        for key, value in errors.items():
            messages.error(request, value, extra_tags=key)
        return redirect('/')

def create(request):
    print("*"*50)
    print("create trip")
    errors = Trip.objects.trip_validator(request.POST)
    print(errors)
    if len(errors) > 0:
        for key, value in errors.items():
            messages.error(request, value, extra_tags= key)
        return redirect("./new")
    else:
        user = User.objects.get(id=request.session['id'])
        new_trip = Trip.objects.create(destination=request.POST['destination'], plan=request.POST['plan'], created_by=user, start=request.POST['start'], end=request.POST['end'])
        print(new_trip)
    return redirect(reverse("trip:trips"))

def edit(request, id):
    print("*"*50)
    print("got to edit")
    if 'id' in request.session:
        #Validation that trip is in user's account
        user = User.objects.get(id=request.session['id'])
        user_trips = Trip.objects.filter(created_by=user)
        print(user_trips)
        for trip in user_trips:
            if int(trip.id) == int(id):
                the_trip = Trip.objects.get(id=id)
                trip_start = the_trip.start
                trip_end = the_trip.end
                print(type(trip_start))
                context = {
                    'user_info': User.objects.get(id=request.session['id']),
                    'trip_info': Trip.objects.get(id=id),
                    'start_info': trip_start,
                    'end_info': trip_end,
                    'trip_id': id,
                }
                return render(request, "tripTrack/edit.html", context)
        return redirect(reverse("trip:trips"))
    else:
        errors = {}
        errors['login'] = "You must login to view the site"
        for key, value in errors.items():
            messages.error(request, value, extra_tags=key)
        return redirect('/')

def update(request):
    print("*"*50)
    print("update trip")
    trip_id = request.POST['trip_id']
    errors = Trip.objects.trip_validator(request.POST)
    print(errors)
    if len(errors) > 0:
        for key, value in errors.items():
            messages.error(request, value, extra_tags=key)
        return redirect(reverse('trip:edit', kwargs={'id':trip_id}))
    else:
        trip_to_update = Trip.objects.get(id=trip_id)
        print(trip_to_update)
        trip_to_update.destination = request.POST['destination']
        trip_to_update.plan = request.POST['plan']
        trip_to_update.start = request.POST['start']
        trip_to_update.end = request.POST['end']
        trip_to_update.save()
    return redirect(reverse("trip:trips"))

def delete(request, id):
    print("*"*50)
    print("delete trip")
    #Validation that trip is in user's account
    user = User.objects.get(id=request.session['id'])
    user_trips = Trip.objects.filter(created_by=user)
    for trip in user_trips:
        if int(trip.id) == int(id):
            trip_to_delete = Trip.objects.get(id=id)
            trip_to_delete.delete()
    return redirect(reverse("trip:trips"))

def info(request, id):
    print("*"*50)
    print("trip info")
    if 'id' in request.session:
        user = User.objects.get(id=request.session['id'])
        this_trip = Trip.objects.get(id=id)
        print(this_trip)
        joinerz = this_trip.joined.all()
        print(joinerz)
        context = {
            'user_info': User.objects.get(id=request.session['id']),
            'trip_info': Trip.objects.get(id=id),
            'joined_trip': joinerz
        }
        return render(request, "tripTrack/info.html", context)
    else:
        errors = {}
        errors['login'] = "You must login to view the site"
        for key, value in errors.items():
            messages.error(request, value, extra_tags=key)
        return redirect('/')

def join(request, id):
    print("*"*50)
    print("join trip")
    #Validation that trip is not user's account
    this_user = User.objects.get(id=request.session['id'])
    this_trip = Trip.objects.get(id=id)
    if this_trip.created_by != this_user:
        this_trip.joined.add(this_user)
    return redirect(reverse("trip:trips"))

def cancel(request, id):
    print("*"*50)
    print("cancel trip")
    this_trip = Trip.objects.get(id=id)
    this_user = User.objects.get(id=request.session['id'])
    this_trip.joined.remove(this_user)
    return redirect(reverse("trip:trips"))