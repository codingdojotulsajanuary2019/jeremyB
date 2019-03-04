from django.db import models
from apps.login_app.models import User
from datetime import datetime

class TripManager(models.Manager):
    def trip_validator(self, postData):
        errors = {}
        print("Validation for trip")

        #Destination Validations
        if len(postData['destination']) == 0:
            errors['destination'] = "Please enter a destination."
        else:
            if len(postData['destination']) < 3:
                errors['destination'] = "destination must be longer than 3 characters."
        
        #Description Validations
        if len(postData['plan']) == 0:
            errors['plan'] = "Please enter a plan."
        else:
            if len(postData['plan']) < 3:
                errors['plan'] = "Plan must be longer than 3 characters."
        
        #Start Date Validations

        if postData['start'] == '':
            errors['start'] = "Please enter a start date."
        else:
            start_date = datetime.strptime(postData['start'], '%Y-%m-%d')
            if start_date < datetime.now():
                errors['start'] = "Start date must be in future."

        #End Date Validations

        if postData['end'] == '':
            errors['end'] = "Please enter a end date."
        else:
            end_date = datetime.strptime(postData['end'], '%Y-%m-%d')
            if end_date < start_date:
                errors['end'] = "Cannot travel back in time."


        return errors
# Create your models here.
class Trip(models.Model):
    destination = models.CharField(max_length=255)
    plan = models.TextField()
    created_by = models.ForeignKey(User, related_name="planner")
    joined = models.ManyToManyField(User, blank=True, related_name="joiner")
    start = models.DateField()
    end = models.DateField()
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)
    objects = TripManager()
        
    def __repr__(self):
        return f"Trip: {self.destination} {self.created_by}"