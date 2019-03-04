from django.db import models
from datetime import datetime, timedelta
import re
import bcrypt

class ModelManager(models.Manager):
    def register_validator(self, postData):
        errors = {}
        print("Validating Registration")
        #First Name Validations
        if not User.objects.filter(email=postData['email']): 
            if len(postData['fname']) == 0:
                errors['fname'] = "Please enter a first name"
            else:
                if len(postData['fname']) < 2:
                    errors['fname'] = "First name should be at least 2 characters"
            
            #Last Name Validations
            if len(postData['lname']) == 0:
                if len(postData['lname']) < 2:
                    errors['lname'] = "Last name should be at least 2 characters"
            

            #Email Validations
            if len(postData['email']) == 0:
                errors['email'] = "Please enter an email address"
            else:
                EMAIL_REGEX = re.compile(r'^[a-zA-Z0-9.+_-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]+$')
                if not EMAIL_REGEX.match(postData['email']):
                    errors['email'] = "Please enter a valid email address"

            #Password Validations
            if len(postData['pword']) == 0:
                errors['pword'] = "Please enter a password"
                if len(postData['pword']) < 8:
                    errors['pword'] = "Please enter a longer password"

            if postData['pword'] != postData['cpword']:
                errors['cpword'] = "Passwords and confirm passwords do not match"
        else:
            errors['email'] = "Email already has an account associated"
        return errors

    def login_validator(self, postData):
        errors = {}
        print("Validating Login")
        
        #Email Validation
        if not postData['login_email']:
            errors['login'] = "Please enter a valid login"
        else:
            user_info = User.objects.filter(email=postData['login_email'])
            if not user_info:
                errors['login'] = "Please enter a valid username"
            else:
                user = User.objects.filter(email=postData['login_email']).values()
                user_pw = user[0]['password']
                #Password Validation
                if not postData['login_pword']:
                    errors['login'] = "Please enter a valid login"
                else:
                    if bcrypt.checkpw(postData['login_pword'].encode(), user_pw.encode()):
                        print("password match")
                    else:
                        errors['login'] = "Please enter a valid password"

        return errors


class User(models.Model):
    fname = models.CharField(max_length=45)
    lname = models.CharField(max_length=45)
    email = models.CharField(max_length=255)
    password = models.CharField(max_length=255)
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)
    objects = ModelManager()

    def __repr__(self):
        return f"User Name: {self.fname} {self.lname}"