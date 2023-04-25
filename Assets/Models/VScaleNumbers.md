## VScale Numbers

### Rail
Rail top surface is at y=0

Rails straddle X axis, and go along Z

Rails are 3” top (x), 7” high (y) … 0.0762m x 0.1778m

Rails inner faces sit at +- 0.7175m (x)
- From center, adjust by 1/2 width (1.5”,  0.0381m) to +-0.7556 (x)

### Wheel Height (diameter)
Wheels are 36” diameter, 0.9144m

Wheels have a 1 in 20 conical shape

Wheel faces (treads) are 3” (x)

Wheel flanges are 1.03”

Wheels sit 1/2 diameter above rail (y),  18”  0.45725m

### Wheel - Rail alignment
x+ and x- wheels of a wheelset straddle the origin (x) +- 0.69215
- Slightly inside the rail straddle

### Wheelbase
Wheelsets have a wheelbase (wheel center to wheel center, z) of 72”  1.8288m
- Straddle the origin (z) +- 0.9144

Axels are placed at same y and z as wheels

### Truck
Truck_sides has both +x and -x in one mesh, and sits up (y) same as wheels, 0.4572m

### Parts
- axel.fbx
- truck_sides.fbx
- wheel_-x.fbx
- wheel_+x.fbx
- wheel_tread_-x.fbx
- wheel_flange_-x.fbx
- wheel_tread_+x.fbx
- wheel_flange_+x.fbx

### Part Placements

| PART            | FRONT (x, y, z)          | BACK (x, y, z)            |
|-----------------|--------------------------|---------------------------|
| axel.fbx        | 0, 0.4572, 0.9144        | 0, 0.4572, -0.9144        |
| wheel_-x.fbx    | -0.69215, 0.4572, 0.9144 | -0.69215, 0.4572, -0.9144 |
| wheel_+x.fbx    | 0.69215, 0.4572, 0.9144  | 0.69215, 0.4572, -0.9144  |
| truck_sides.fbx | 0, 0.4572, 0             | -                         |
