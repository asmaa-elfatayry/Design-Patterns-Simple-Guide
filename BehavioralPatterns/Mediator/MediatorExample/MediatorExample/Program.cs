using MediatorExample;

TrainStation station = new TrainStation();

Train train1 = new Train("Express 1", station);
Train train2 = new Train("Local 2", station);

station.RegisterTrain(train1);
station.RegisterTrain(train2);

train1.RequestTrack();
train2.RequestTrack();
train1.LeaveTrack();
train2.RequestTrack();