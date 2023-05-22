# simulations
This repository holds all of the simulation software for the team. All simulations are created in unity and compiled for windows, macos, and linux. 

To run the simulation, download the appropriate installer. Then, run the executable file to install and run the simulation.

You can download Unity from their website [here](https://unity3d.com/get-unity/download). You will need to create an account to use the downloaded software. The license is free for all.

These simulations will be used to train multiple Convolutional Neural Networks (CNNs) to perform various tasks. The CNNs will be trained using the [TensorFlow](https://www.tensorflow.org/) library. The CNNs will be trained on a desktop computer and then deployed to the Jetson AGX Orin. The Jetson AGX Orin will then be used to run the CNNs in real time on the robot. Training will still need to take place after the robot is built, but the simulations will be used to train the CNNs before the robot is built.

## Simulation 1: Object Detection
This will contain one camera viewpoint and a random object generator (random = objects taken from a set of objects that will be used by the competition). The robot will need to correctly detect the object and classify it.


## Simulation 2: Object Tracking
This will contain one camera viewpoint and a random object generator that will move to random locations in the camera's field of view. The robot will need to correctly detect the object and classify it. The robot will also need to track the object as it moves around the camera's field of view (without actually moving the camera).


## Simulation 3: Object Avoidance
Beat saber style game where the robot needs to avoid objects coming at it from the front. The robot will need to correctly detect the object and classify it. The robot will also need to avoid the object.


## Simulation 4: Pass the Gate
The qualifier for the AUV competition is to pass through a gate and travel around a pole and back through the gate. This simulation will be used to train the robot to pass through the gate. The robot will need to correctly detect the gate and classify it. The robot will also need to pass through the gate.


## Simulation 5: Pass the Gate and Travel Around the Pole and Back Through the Gate
The qualifier for the AUV competition is to pass through a gate and travel around a pole and back through the gate. This simulation will be used to train the robot to pass through the gate, travel around the pole, and back through the gate. The robot will need to correctly detect the gate and classify it. The robot will also need to pass through the gate, travel around the pole, and back through the gate.


## Simulation 6: AUV Competition
This will be a simulator for the AUV competition. It will be almost exactly the same as what the sub will need to do at competition. The robot will need to complete all tasks in the competition.

